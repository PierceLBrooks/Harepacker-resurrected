
import os
import sys
from PIL import Image, ImageDraw

def run(target):
    Image.MAX_IMAGE_PIXELS = None
    names = []
    out = os.path.join(target, "out")
    if not (os.path.exists(target)):
        os.makedirs(target)
    if not (os.path.exists(out)):
        os.makedirs(out)
    for root, folders, files in os.walk(target):
        for name in files:
            print(str(name))
            names.append(name)
        break
    names = list(sorted(names))
    pairs = {}
    pair = []
    keys = []
    for i in range(len(names)):
        if (len(pair) < 1):
            pair.append(names[i])
            continue
        else:
            split = names[i].split("_")
            if (len(split) > 0):
              if (pair[0].startswith(split[0]+"_")):
                  pair.append(names[i])
        if (len(pair) == 2):
            temp = pair[0].split("_")[0]
            for i in range(len(pair)):
                pair[i] = os.path.join(target, pair[i])
            pairs[temp] = pair
            keys.append(temp)
        pair = []
    transparent = str((0, 0, 0, 0))
    print(transparent)
    for i in range(len(keys)):
        key = keys[i]
        if not (key in pairs):
            continue
        print(key+" "+str(i)+"/"+str(len(keys)))
        if (os.path.exists(os.path.join(out, key+".png"))):
            continue
        pair = pairs[key]
        background = pair[0]
        try:
            background = Image.open(background)
        except:
            background = None
        if (background == None):
            continue
        data = background.load()
        size = background.size
        if (size[0]*size[1] > 4000000):
            continue
        #print(str(size))
        #"""
        #print(str(data[0, 0]))
        x = 0
        y = 0
        width = size[0]
        height = size[1]
        for i in range(size[1]):
            for j in range(size[0]):
                if (j == 0):
                    continue
                if not ((str(data[j-1, i]) == transparent) and not (str(data[j, i]) == transparent)):
                    continue
                if (j > x):
                    x = j
                    break
        for i in range(size[0]):
            for j in range(size[1]):
                if (j == 0):
                    continue
                if not ((str(data[i, j-1]) == transparent) and not (str(data[i, j]) == transparent)):
                    continue
                if (j > y):
                    y = j
                    break
        for i in range(size[1]):
            for j in range(size[0]-1, x, -1):
                if (j == size[0]-1):
                    continue
                if not ((str(data[j+1, i]) == transparent) and not (str(data[j, i]) == transparent)):
                    continue
                if (j < width):
                    width = j
                    break
        for i in range(size[0]):
            for j in range(size[1]-1, y, -1):
                if (j == size[1]-1):
                    continue
                if not ((str(data[i, j+1]) == transparent) and not (str(data[i, j]) == transparent)):
                    continue
                if (j < height):
                    height = j
                    break
        width -= x
        height -= y
        #print(str(x))
        #print(str(y))
        #print(str(width))
        #print(str(height))
        scaleX = float(size[0])/float(width)
        scaleY = float(size[1])/float(height)
        scale = min(scaleX, scaleY)
        if (scale > 50.0):
            continue
        #print(str(scale))
        #"""
        x = size[0]
        y = size[1]
        width = 0
        height = 0
        for i in range(size[1]):
            for j in range(size[0]):
                if (j == 0):
                    if not (str(data[j, i]) == transparent):
                        x = j
                        break
                    continue
                if not ((str(data[j-1, i]) == transparent) and not (str(data[j, i]) == transparent)):
                    continue
                if (j < x):
                    x = j
                    break
        for i in range(size[0]):
            for j in range(size[1]):
                if (j == 0):
                    if not (str(data[i, j]) == transparent):
                        y = j
                        break
                    continue
                if not ((str(data[i, j-1]) == transparent) and not (str(data[i, j]) == transparent)):
                    continue
                if (j < y):
                    y = j
                    break
        for i in range(size[1]):
            for j in range(size[0]-1, x, -1):
                if (j == size[0]-1):
                    if not (str(data[j, i]) == transparent):
                        width = j
                        break
                    continue
                if not ((str(data[j+1, i]) == transparent) and not (str(data[j, i]) == transparent)):
                    continue
                if (j > width):
                    width = j
                    break
        for i in range(size[0]):
            for j in range(size[1]-1, y, -1):
                if (j == size[1]-1):
                    if not (str(data[i, j]) == transparent):
                        height = j
                        break
                    continue
                if not ((str(data[i, j+1]) == transparent) and not (str(data[i, j]) == transparent)):
                    continue
                if (j > height):
                    height = j
                    break
        left = min(x, width)
        right = max(x, width)
        top = min(y, height)
        bottom = max(y, height)
        #print(str(left))
        #print(str(right))
        #print(str(top))
        #print(str(bottom))
        try:
            background = background.crop((left, top, right, bottom))
            size = background.size
            background = background.resize((int(float(size[0]*scale)), int(float(size[1])*scale)))
            #background.save(os.path.join(out, "bkg.png"), "PNG")
            foreground = pair[1]
            foreground = Image.open(foreground)
            size = foreground.size
            output = Image.new("RGBA", size)
            size = background.size
            output.alpha_composite(background, (int(float(output.size[0])*0.5)-int(float(size[0])*0.5), int(float(output.size[1])*0.5)-(int(float(size[1])*0.5))))
            #output.alpha_composite(background)
            output.alpha_composite(foreground)
            output.save(os.path.join(out, key+".png"), "PNG")
        except:
            pass
    #print(str(names))
    #print(str(pairs))
    return 0
    
def launch(arguments):
    if (len(arguments) < 2):
        return False
    result = run(arguments[1])
    print(str(result))
    if not (result == 0):
        return False
    return True
    
if (__name__ == "__main__"):
    print(str(launch(sys.argv)))