﻿using HaCreator.CustomControls;
using HaSharedLibrary.GUI;

namespace HaCreator.GUI
{
    partial class InfoEditor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.bgmBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.streetBox = new System.Windows.Forms.TextBox();
            this.markBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.firstUserEnter = new System.Windows.Forms.TextBox();
            this.userEnter = new System.Windows.Forms.TextBox();
            this.mapDesc = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.unknownProps = new System.Windows.Forms.TreeView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
            this.soundPlayer1 = new HaSharedLibrary.GUI.SoundPlayer();
            this.button_selectForcedReturnMap = new System.Windows.Forms.Button();
            this.button_selectReturnMap = new System.Windows.Forms.Button();
            this.yBox = new System.Windows.Forms.NumericUpDown();
            this.label20 = new System.Windows.Forms.Label();
            this.xBox = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.categoryBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.returnHereCBX = new System.Windows.Forms.CheckBox();
            this.cannotReturnCBX = new System.Windows.Forms.CheckBox();
            this.mobRate = new System.Windows.Forms.NumericUpDown();
            this.IDLabel = new System.Windows.Forms.Label();
            this.returnBox = new System.Windows.Forms.NumericUpDown();
            this.forcedRet = new System.Windows.Forms.NumericUpDown();
            this.markImage = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.recovery = new System.Windows.Forms.NumericUpDown();
            this.recoveryEnable = new System.Windows.Forms.CheckBox();
            this.dropRate = new System.Windows.Forms.NumericUpDown();
            this.dropRateEnable = new System.Windows.Forms.CheckBox();
            this.protectEnable = new System.Windows.Forms.CheckBox();
            this.protectItem = new System.Windows.Forms.NumericUpDown();
            this.decInterval = new System.Windows.Forms.NumericUpDown();
            this.decIntervalEnable = new System.Windows.Forms.CheckBox();
            this.label116 = new System.Windows.Forms.Label();
            this.decHP = new System.Windows.Forms.NumericUpDown();
            this.hpDecEnable = new System.Windows.Forms.CheckBox();
            this.dropExpire = new System.Windows.Forms.NumericUpDown();
            this.dropExpireEnable = new System.Windows.Forms.CheckBox();
            this.helpEnable = new System.Windows.Forms.CheckBox();
            this.helpBox = new System.Windows.Forms.TextBox();
            this.label113 = new System.Windows.Forms.Label();
            this.fixedMobCapacity = new System.Windows.Forms.NumericUpDown();
            this.label112 = new System.Windows.Forms.Label();
            this.createMobInterval = new System.Windows.Forms.NumericUpDown();
            this.massEnable = new System.Windows.Forms.CheckBox();
            this.fsBox = new System.Windows.Forms.NumericUpDown();
            this.label110 = new System.Windows.Forms.Label();
            this.fsEnable = new System.Windows.Forms.CheckBox();
            this.lvForceMoveUse = new System.Windows.Forms.CheckBox();
            this.lvForceMove = new System.Windows.Forms.NumericUpDown();
            this.streetNameBox = new System.Windows.Forms.TextBox();
            this.effectEnable = new System.Windows.Forms.CheckBox();
            this.streetNameEnable = new System.Windows.Forms.CheckBox();
            this.mapDescEnable = new System.Windows.Forms.CheckBox();
            this.mapNameEnable = new System.Windows.Forms.CheckBox();
            this.moveLimitEnable = new System.Windows.Forms.CheckBox();
            this.fieldTypeEnable = new System.Windows.Forms.CheckBox();
            this.userEnterEnable = new System.Windows.Forms.CheckBox();
            this.firstUserEnable = new System.Windows.Forms.CheckBox();
            this.lvLimitEnable = new System.Windows.Forms.CheckBox();
            this.timeLimitEnable = new System.Windows.Forms.CheckBox();
            this.effectBox = new System.Windows.Forms.TextBox();
            this.reactorNameShuffle = new System.Windows.Forms.CheckBox();
            this.reactorNameBox = new System.Windows.Forms.TextBox();
            this.reactorShuffle = new System.Windows.Forms.CheckBox();
            this.fieldType = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.mapName = new System.Windows.Forms.TextBox();
            this.timeLimit = new System.Windows.Forms.NumericUpDown();
            this.moveLimit = new System.Windows.Forms.NumericUpDown();
            this.lvLimit = new System.Windows.Forms.NumericUpDown();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.summonMobEnable = new System.Windows.Forms.CheckBox();
            this.allowedItemsRemove = new System.Windows.Forms.Button();
            this.allowedItemsAdd = new System.Windows.Forms.Button();
            this.allowedItems = new System.Windows.Forms.ListBox();
            this.allowedItemsEnable = new System.Windows.Forms.CheckBox();
            this.label114 = new System.Windows.Forms.Label();
            this.autoLieProp = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.autoLieInterval = new System.Windows.Forms.NumericUpDown();
            this.label17 = new System.Windows.Forms.Label();
            this.autoLieEnd = new System.Windows.Forms.NumericUpDown();
            this.label18 = new System.Windows.Forms.Label();
            this.autoLieStart = new System.Windows.Forms.NumericUpDown();
            this.label19 = new System.Windows.Forms.Label();
            this.autoLieDetectorEnable = new System.Windows.Forms.CheckBox();
            this.timedMobMessage = new System.Windows.Forms.TextBox();
            this.label125 = new System.Windows.Forms.Label();
            this.timedMobId = new System.Windows.Forms.NumericUpDown();
            this.label124 = new System.Windows.Forms.Label();
            this.timedMobEnd = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.timedMobStart = new System.Windows.Forms.NumericUpDown();
            this.label121 = new System.Windows.Forms.Label();
            this.timedMobEnable = new System.Windows.Forms.CheckBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.fieldLimitPanel1 = new HaSharedLibrary.GUI.FieldLimitPanel();
            this.optionsList = new HaCreator.CustomControls.BetterCheckedListBox();
            this.label123 = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mobRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.forcedRet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.markImage)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recovery)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dropRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.protectItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.decInterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.decHP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dropExpire)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fixedMobCapacity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.createMobInterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fsBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lvForceMove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moveLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lvLimit)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.autoLieProp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoLieInterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoLieEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoLieStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timedMobId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timedMobEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timedMobStart)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 296);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "BGM:";
            // 
            // bgmBox
            // 
            this.bgmBox.FormattingEnabled = true;
            this.bgmBox.Location = new System.Drawing.Point(142, 284);
            this.bgmBox.Margin = new System.Windows.Forms.Padding(4);
            this.bgmBox.Name = "bgmBox";
            this.bgmBox.Size = new System.Drawing.Size(408, 31);
            this.bgmBox.TabIndex = 1;
            this.bgmBox.SelectedIndexChanged += new System.EventHandler(this.bgmBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 256);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Map ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 28);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Map Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 68);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Street Name:";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(140, 15);
            this.nameBox.Margin = new System.Windows.Forms.Padding(4);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(236, 29);
            this.nameBox.TabIndex = 7;
            // 
            // streetBox
            // 
            this.streetBox.Location = new System.Drawing.Point(140, 54);
            this.streetBox.Margin = new System.Windows.Forms.Padding(4);
            this.streetBox.Name = "streetBox";
            this.streetBox.Size = new System.Drawing.Size(236, 29);
            this.streetBox.TabIndex = 8;
            // 
            // markBox
            // 
            this.markBox.FormattingEnabled = true;
            this.markBox.Location = new System.Drawing.Point(834, 46);
            this.markBox.Margin = new System.Windows.Forms.Padding(4);
            this.markBox.Name = "markBox";
            this.markBox.Size = new System.Drawing.Size(250, 31);
            this.markBox.TabIndex = 10;
            this.markBox.SelectedIndexChanged += new System.EventHandler(this.markBox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(261, 4);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 23);
            this.label5.TabIndex = 36;
            this.label5.Text = "Field Limits:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 146);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 23);
            this.label6.TabIndex = 37;
            this.label6.Text = "Return Map:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 184);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 23);
            this.label9.TabIndex = 40;
            this.label9.Text = "Forced Return:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 4);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(189, 23);
            this.label10.TabIndex = 44;
            this.label10.Text = "Other boolean settings:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(850, 15);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 23);
            this.label11.TabIndex = 45;
            this.label11.Text = "Map Mark:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(206, 460);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(228, 23);
            this.label13.TabIndex = 81;
            this.label13.Text = "Only known effect is Bubbles";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(372, 4);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(309, 23);
            this.label15.TabIndex = 52;
            this.label15.Text = " (do not touch if you don\'t understand)";
            // 
            // firstUserEnter
            // 
            this.firstUserEnter.Enabled = false;
            this.firstUserEnter.Location = new System.Drawing.Point(206, 147);
            this.firstUserEnter.Margin = new System.Windows.Forms.Padding(4);
            this.firstUserEnter.Name = "firstUserEnter";
            this.firstUserEnter.Size = new System.Drawing.Size(236, 29);
            this.firstUserEnter.TabIndex = 60;
            // 
            // userEnter
            // 
            this.userEnter.Enabled = false;
            this.userEnter.Location = new System.Drawing.Point(206, 186);
            this.userEnter.Margin = new System.Windows.Forms.Padding(4);
            this.userEnter.Name = "userEnter";
            this.userEnter.Size = new System.Drawing.Size(236, 29);
            this.userEnter.TabIndex = 62;
            // 
            // mapDesc
            // 
            this.mapDesc.Enabled = false;
            this.mapDesc.Location = new System.Drawing.Point(206, 344);
            this.mapDesc.Margin = new System.Windows.Forms.Padding(4);
            this.mapDesc.Name = "mapDesc";
            this.mapDesc.Size = new System.Drawing.Size(238, 29);
            this.mapDesc.TabIndex = 68;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(788, 4);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(168, 23);
            this.label24.TabIndex = 69;
            this.label24.Text = "Unknown properties:";
            // 
            // unknownProps
            // 
            this.unknownProps.Location = new System.Drawing.Point(792, 36);
            this.unknownProps.Margin = new System.Windows.Forms.Padding(4);
            this.unknownProps.Name = "unknownProps";
            this.unknownProps.Size = new System.Drawing.Size(366, 698);
            this.unknownProps.TabIndex = 70;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1170, 788);
            this.tabControl1.TabIndex = 71;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.label22);
            this.tabPage1.Controls.Add(this.label21);
            this.tabPage1.Controls.Add(this.elementHost1);
            this.tabPage1.Controls.Add(this.button_selectForcedReturnMap);
            this.tabPage1.Controls.Add(this.button_selectReturnMap);
            this.tabPage1.Controls.Add(this.yBox);
            this.tabPage1.Controls.Add(this.label20);
            this.tabPage1.Controls.Add(this.xBox);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.categoryBox);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.returnHereCBX);
            this.tabPage1.Controls.Add(this.cannotReturnCBX);
            this.tabPage1.Controls.Add(this.mobRate);
            this.tabPage1.Controls.Add(this.IDLabel);
            this.tabPage1.Controls.Add(this.bgmBox);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.nameBox);
            this.tabPage1.Controls.Add(this.streetBox);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.returnBox);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.forcedRet);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.markImage);
            this.tabPage1.Controls.Add(this.markBox);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Location = new System.Drawing.Point(4, 32);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1162, 752);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Essential Settings";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(146, 666);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(20, 23);
            this.label22.TabIndex = 162;
            this.label22.Text = "X";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(285, 666);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(19, 23);
            this.label21.TabIndex = 161;
            this.label21.Text = "Y";
            // 
            // elementHost1
            // 
            this.elementHost1.Location = new System.Drawing.Point(12, 328);
            this.elementHost1.Name = "elementHost1";
            this.elementHost1.Size = new System.Drawing.Size(710, 208);
            this.elementHost1.TabIndex = 160;
            this.elementHost1.Text = "elementHost1";
            this.elementHost1.Child = this.soundPlayer1;
            // 
            // button_selectForcedReturnMap
            // 
            this.button_selectForcedReturnMap.Location = new System.Drawing.Point(530, 176);
            this.button_selectForcedReturnMap.Name = "button_selectForcedReturnMap";
            this.button_selectForcedReturnMap.Size = new System.Drawing.Size(92, 28);
            this.button_selectForcedReturnMap.TabIndex = 159;
            this.button_selectForcedReturnMap.Text = "Select";
            this.button_selectForcedReturnMap.UseVisualStyleBackColor = true;
            this.button_selectForcedReturnMap.Click += new System.EventHandler(this.button_selectForcedReturnMap_Click);
            // 
            // button_selectReturnMap
            // 
            this.button_selectReturnMap.Location = new System.Drawing.Point(530, 134);
            this.button_selectReturnMap.Name = "button_selectReturnMap";
            this.button_selectReturnMap.Size = new System.Drawing.Size(92, 32);
            this.button_selectReturnMap.TabIndex = 158;
            this.button_selectReturnMap.Text = "Select";
            this.button_selectReturnMap.UseVisualStyleBackColor = true;
            this.button_selectReturnMap.Click += new System.EventHandler(this.button_selectReturnMap_Click);
            // 
            // yBox
            // 
            this.yBox.Location = new System.Drawing.Point(312, 663);
            this.yBox.Margin = new System.Windows.Forms.Padding(4);
            this.yBox.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.yBox.Name = "yBox";
            this.yBox.Size = new System.Drawing.Size(94, 29);
            this.yBox.TabIndex = 157;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(27, 666);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(102, 23);
            this.label20.TabIndex = 156;
            this.label20.Text = "Dimensions:";
            // 
            // xBox
            // 
            this.xBox.Location = new System.Drawing.Point(172, 663);
            this.xBox.Margin = new System.Windows.Forms.Padding(4);
            this.xBox.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.xBox.Name = "xBox";
            this.xBox.Size = new System.Drawing.Size(94, 29);
            this.xBox.TabIndex = 155;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(45, 106);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 23);
            this.label8.TabIndex = 153;
            this.label8.Text = "Category:";
            // 
            // categoryBox
            // 
            this.categoryBox.Location = new System.Drawing.Point(140, 93);
            this.categoryBox.Margin = new System.Windows.Forms.Padding(4);
            this.categoryBox.Name = "categoryBox";
            this.categoryBox.Size = new System.Drawing.Size(236, 29);
            this.categoryBox.TabIndex = 154;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(45, 224);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 23);
            this.label7.TabIndex = 152;
            this.label7.Text = "mobRate:";
            // 
            // returnHereCBX
            // 
            this.returnHereCBX.AutoSize = true;
            this.returnHereCBX.Location = new System.Drawing.Point(387, 176);
            this.returnHereCBX.Margin = new System.Windows.Forms.Padding(4);
            this.returnHereCBX.Name = "returnHereCBX";
            this.returnHereCBX.Size = new System.Drawing.Size(126, 27);
            this.returnHereCBX.TabIndex = 151;
            this.returnHereCBX.Text = "Return here";
            this.returnHereCBX.CheckedChanged += new System.EventHandler(this.returnHereCBX_CheckedChanged);
            // 
            // cannotReturnCBX
            // 
            this.cannotReturnCBX.AutoSize = true;
            this.cannotReturnCBX.Location = new System.Drawing.Point(387, 136);
            this.cannotReturnCBX.Margin = new System.Windows.Forms.Padding(4);
            this.cannotReturnCBX.Name = "cannotReturnCBX";
            this.cannotReturnCBX.Size = new System.Drawing.Size(126, 27);
            this.cannotReturnCBX.TabIndex = 150;
            this.cannotReturnCBX.Text = "Return here";
            this.cannotReturnCBX.CheckedChanged += new System.EventHandler(this.cannotReturnCBX_CheckedChanged);
            // 
            // mobRate
            // 
            this.mobRate.DecimalPlaces = 5;
            this.mobRate.Location = new System.Drawing.Point(140, 210);
            this.mobRate.Margin = new System.Windows.Forms.Padding(4);
            this.mobRate.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.mobRate.Name = "mobRate";
            this.mobRate.Size = new System.Drawing.Size(238, 29);
            this.mobRate.TabIndex = 54;
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Location = new System.Drawing.Point(140, 256);
            this.IDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(46, 23);
            this.IDLabel.TabIndex = 53;
            this.IDLabel.Text = "1234";
            // 
            // returnBox
            // 
            this.returnBox.Location = new System.Drawing.Point(140, 132);
            this.returnBox.Margin = new System.Windows.Forms.Padding(4);
            this.returnBox.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.returnBox.Name = "returnBox";
            this.returnBox.Size = new System.Drawing.Size(238, 29);
            this.returnBox.TabIndex = 38;
            // 
            // forcedRet
            // 
            this.forcedRet.Location = new System.Drawing.Point(140, 171);
            this.forcedRet.Margin = new System.Windows.Forms.Padding(4);
            this.forcedRet.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.forcedRet.Name = "forcedRet";
            this.forcedRet.Size = new System.Drawing.Size(238, 29);
            this.forcedRet.TabIndex = 41;
            // 
            // markImage
            // 
            this.markImage.Location = new System.Drawing.Point(768, 33);
            this.markImage.Margin = new System.Windows.Forms.Padding(4);
            this.markImage.Name = "markImage";
            this.markImage.Size = new System.Drawing.Size(57, 57);
            this.markImage.TabIndex = 9;
            this.markImage.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.recovery);
            this.tabPage2.Controls.Add(this.recoveryEnable);
            this.tabPage2.Controls.Add(this.dropRate);
            this.tabPage2.Controls.Add(this.dropRateEnable);
            this.tabPage2.Controls.Add(this.protectEnable);
            this.tabPage2.Controls.Add(this.protectItem);
            this.tabPage2.Controls.Add(this.decInterval);
            this.tabPage2.Controls.Add(this.decIntervalEnable);
            this.tabPage2.Controls.Add(this.label116);
            this.tabPage2.Controls.Add(this.decHP);
            this.tabPage2.Controls.Add(this.hpDecEnable);
            this.tabPage2.Controls.Add(this.dropExpire);
            this.tabPage2.Controls.Add(this.dropExpireEnable);
            this.tabPage2.Controls.Add(this.helpEnable);
            this.tabPage2.Controls.Add(this.helpBox);
            this.tabPage2.Controls.Add(this.label113);
            this.tabPage2.Controls.Add(this.fixedMobCapacity);
            this.tabPage2.Controls.Add(this.label112);
            this.tabPage2.Controls.Add(this.createMobInterval);
            this.tabPage2.Controls.Add(this.massEnable);
            this.tabPage2.Controls.Add(this.fsBox);
            this.tabPage2.Controls.Add(this.label110);
            this.tabPage2.Controls.Add(this.fsEnable);
            this.tabPage2.Controls.Add(this.lvForceMoveUse);
            this.tabPage2.Controls.Add(this.lvForceMove);
            this.tabPage2.Controls.Add(this.streetNameBox);
            this.tabPage2.Controls.Add(this.effectEnable);
            this.tabPage2.Controls.Add(this.streetNameEnable);
            this.tabPage2.Controls.Add(this.mapDescEnable);
            this.tabPage2.Controls.Add(this.mapNameEnable);
            this.tabPage2.Controls.Add(this.moveLimitEnable);
            this.tabPage2.Controls.Add(this.fieldTypeEnable);
            this.tabPage2.Controls.Add(this.userEnterEnable);
            this.tabPage2.Controls.Add(this.firstUserEnable);
            this.tabPage2.Controls.Add(this.lvLimitEnable);
            this.tabPage2.Controls.Add(this.timeLimitEnable);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.effectBox);
            this.tabPage2.Controls.Add(this.reactorNameShuffle);
            this.tabPage2.Controls.Add(this.reactorNameBox);
            this.tabPage2.Controls.Add(this.reactorShuffle);
            this.tabPage2.Controls.Add(this.fieldType);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.mapName);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.mapDesc);
            this.tabPage2.Controls.Add(this.firstUserEnter);
            this.tabPage2.Controls.Add(this.userEnter);
            this.tabPage2.Controls.Add(this.timeLimit);
            this.tabPage2.Controls.Add(this.moveLimit);
            this.tabPage2.Controls.Add(this.lvLimit);
            this.tabPage2.Location = new System.Drawing.Point(4, 32);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1162, 752);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Optional Settings";
            // 
            // recovery
            // 
            this.recovery.DecimalPlaces = 5;
            this.recovery.Enabled = false;
            this.recovery.Location = new System.Drawing.Point(278, 578);
            this.recovery.Margin = new System.Windows.Forms.Padding(4);
            this.recovery.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.recovery.Name = "recovery";
            this.recovery.Size = new System.Drawing.Size(168, 29);
            this.recovery.TabIndex = 174;
            // 
            // recoveryEnable
            // 
            this.recoveryEnable.AutoSize = true;
            this.recoveryEnable.Location = new System.Drawing.Point(4, 578);
            this.recoveryEnable.Margin = new System.Windows.Forms.Padding(4);
            this.recoveryEnable.Name = "recoveryEnable";
            this.recoveryEnable.Size = new System.Drawing.Size(236, 27);
            this.recoveryEnable.TabIndex = 171;
            this.recoveryEnable.Text = "Recovery rate (Sauna = 3):";
            this.recoveryEnable.CheckedChanged += new System.EventHandler(this.enablingCheckBox_CheckChanged);
            // 
            // dropRate
            // 
            this.dropRate.DecimalPlaces = 5;
            this.dropRate.Enabled = false;
            this.dropRate.Location = new System.Drawing.Point(276, 534);
            this.dropRate.Margin = new System.Windows.Forms.Padding(4);
            this.dropRate.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.dropRate.Name = "dropRate";
            this.dropRate.Size = new System.Drawing.Size(168, 29);
            this.dropRate.TabIndex = 170;
            // 
            // dropRateEnable
            // 
            this.dropRateEnable.AutoSize = true;
            this.dropRateEnable.Location = new System.Drawing.Point(4, 538);
            this.dropRateEnable.Margin = new System.Windows.Forms.Padding(4);
            this.dropRateEnable.Name = "dropRateEnable";
            this.dropRateEnable.Size = new System.Drawing.Size(113, 27);
            this.dropRateEnable.TabIndex = 169;
            this.dropRateEnable.Text = "Drop rate:";
            this.dropRateEnable.CheckedChanged += new System.EventHandler(this.enablingCheckBox_CheckChanged);
            // 
            // protectEnable
            // 
            this.protectEnable.AutoSize = true;
            this.protectEnable.Enabled = false;
            this.protectEnable.Location = new System.Drawing.Point(579, 476);
            this.protectEnable.Margin = new System.Windows.Forms.Padding(4);
            this.protectEnable.Name = "protectEnable";
            this.protectEnable.Size = new System.Drawing.Size(195, 27);
            this.protectEnable.TabIndex = 168;
            this.protectEnable.Text = "Anti-decrement item";
            this.protectEnable.CheckedChanged += new System.EventHandler(this.enablingCheckBox_CheckChanged);
            // 
            // protectItem
            // 
            this.protectItem.Enabled = false;
            this.protectItem.Location = new System.Drawing.Point(814, 472);
            this.protectItem.Margin = new System.Windows.Forms.Padding(4);
            this.protectItem.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.protectItem.Name = "protectItem";
            this.protectItem.Size = new System.Drawing.Size(184, 29);
            this.protectItem.TabIndex = 166;
            // 
            // decInterval
            // 
            this.decInterval.Enabled = false;
            this.decInterval.Location = new System.Drawing.Point(814, 434);
            this.decInterval.Margin = new System.Windows.Forms.Padding(4);
            this.decInterval.Name = "decInterval";
            this.decInterval.Size = new System.Drawing.Size(184, 29);
            this.decInterval.TabIndex = 164;
            // 
            // decIntervalEnable
            // 
            this.decIntervalEnable.AutoSize = true;
            this.decIntervalEnable.Enabled = false;
            this.decIntervalEnable.Location = new System.Drawing.Point(579, 436);
            this.decIntervalEnable.Margin = new System.Windows.Forms.Padding(4);
            this.decIntervalEnable.Name = "decIntervalEnable";
            this.decIntervalEnable.Size = new System.Drawing.Size(233, 27);
            this.decIntervalEnable.TabIndex = 163;
            this.decIntervalEnable.Text = "Custom Interval (seconds)";
            this.decIntervalEnable.CheckedChanged += new System.EventHandler(this.enablingCheckBox_CheckChanged);
            // 
            // label116
            // 
            this.label116.AutoSize = true;
            this.label116.Location = new System.Drawing.Point(585, 400);
            this.label116.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label116.Name = "label116";
            this.label116.Size = new System.Drawing.Size(125, 23);
            this.label116.TabIndex = 162;
            this.label116.Text = "HP to decrease";
            // 
            // decHP
            // 
            this.decHP.Enabled = false;
            this.decHP.Location = new System.Drawing.Point(814, 396);
            this.decHP.Margin = new System.Windows.Forms.Padding(4);
            this.decHP.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.decHP.Name = "decHP";
            this.decHP.Size = new System.Drawing.Size(184, 29);
            this.decHP.TabIndex = 161;
            // 
            // hpDecEnable
            // 
            this.hpDecEnable.AutoSize = true;
            this.hpDecEnable.Location = new System.Drawing.Point(549, 362);
            this.hpDecEnable.Margin = new System.Windows.Forms.Padding(4);
            this.hpDecEnable.Name = "hpDecEnable";
            this.hpDecEnable.Size = new System.Drawing.Size(147, 27);
            this.hpDecEnable.TabIndex = 160;
            this.hpDecEnable.Text = "HP Decrement";
            this.hpDecEnable.CheckedChanged += new System.EventHandler(this.enablingCheckBox_CheckChanged);
            // 
            // dropExpire
            // 
            this.dropExpire.Enabled = false;
            this.dropExpire.Location = new System.Drawing.Point(276, 495);
            this.dropExpire.Margin = new System.Windows.Forms.Padding(4);
            this.dropExpire.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.dropExpire.Name = "dropExpire";
            this.dropExpire.Size = new System.Drawing.Size(168, 29);
            this.dropExpire.TabIndex = 159;
            // 
            // dropExpireEnable
            // 
            this.dropExpireEnable.AutoSize = true;
            this.dropExpireEnable.Location = new System.Drawing.Point(4, 498);
            this.dropExpireEnable.Margin = new System.Windows.Forms.Padding(4);
            this.dropExpireEnable.Name = "dropExpireEnable";
            this.dropExpireEnable.Size = new System.Drawing.Size(274, 27);
            this.dropExpireEnable.TabIndex = 158;
            this.dropExpireEnable.Text = "Drop expiration time (seconds):";
            this.dropExpireEnable.CheckedChanged += new System.EventHandler(this.enablingCheckBox_CheckChanged);
            // 
            // helpEnable
            // 
            this.helpEnable.AutoSize = true;
            this.helpEnable.Location = new System.Drawing.Point(549, 542);
            this.helpEnable.Margin = new System.Windows.Forms.Padding(4);
            this.helpEnable.Name = "helpEnable";
            this.helpEnable.Size = new System.Drawing.Size(179, 27);
            this.helpEnable.TabIndex = 156;
            this.helpEnable.Text = "Map help message";
            this.helpEnable.CheckedChanged += new System.EventHandler(this.enablingCheckBox_CheckChanged);
            // 
            // helpBox
            // 
            this.helpBox.AcceptsReturn = true;
            this.helpBox.Enabled = false;
            this.helpBox.Location = new System.Drawing.Point(582, 573);
            this.helpBox.Margin = new System.Windows.Forms.Padding(4);
            this.helpBox.Multiline = true;
            this.helpBox.Name = "helpBox";
            this.helpBox.Size = new System.Drawing.Size(404, 130);
            this.helpBox.TabIndex = 155;
            // 
            // label113
            // 
            this.label113.AutoSize = true;
            this.label113.Location = new System.Drawing.Point(658, 321);
            this.label113.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label113.Name = "label113";
            this.label113.Size = new System.Drawing.Size(112, 23);
            this.label113.TabIndex = 153;
            this.label113.Text = "Mob capacity";
            // 
            // fixedMobCapacity
            // 
            this.fixedMobCapacity.Enabled = false;
            this.fixedMobCapacity.Location = new System.Drawing.Point(780, 321);
            this.fixedMobCapacity.Margin = new System.Windows.Forms.Padding(4);
            this.fixedMobCapacity.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.fixedMobCapacity.Name = "fixedMobCapacity";
            this.fixedMobCapacity.Size = new System.Drawing.Size(72, 29);
            this.fixedMobCapacity.TabIndex = 152;
            // 
            // label112
            // 
            this.label112.AutoSize = true;
            this.label112.Location = new System.Drawing.Point(552, 282);
            this.label112.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label112.Name = "label112";
            this.label112.Size = new System.Drawing.Size(214, 23);
            this.label112.TabIndex = 151;
            this.label112.Text = "Respawn interval (seconds)";
            // 
            // createMobInterval
            // 
            this.createMobInterval.Enabled = false;
            this.createMobInterval.Location = new System.Drawing.Point(780, 276);
            this.createMobInterval.Margin = new System.Windows.Forms.Padding(4);
            this.createMobInterval.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.createMobInterval.Name = "createMobInterval";
            this.createMobInterval.Size = new System.Drawing.Size(72, 29);
            this.createMobInterval.TabIndex = 150;
            // 
            // massEnable
            // 
            this.massEnable.AutoSize = true;
            this.massEnable.Location = new System.Drawing.Point(549, 248);
            this.massEnable.Margin = new System.Windows.Forms.Padding(4);
            this.massEnable.Name = "massEnable";
            this.massEnable.Size = new System.Drawing.Size(298, 27);
            this.massEnable.TabIndex = 149;
            this.massEnable.Text = "Enable mob-massacre PQ features";
            this.massEnable.CheckedChanged += new System.EventHandler(this.enablingCheckBox_CheckChanged);
            // 
            // fsBox
            // 
            this.fsBox.DecimalPlaces = 5;
            this.fsBox.Enabled = false;
            this.fsBox.Location = new System.Drawing.Point(644, 170);
            this.fsBox.Margin = new System.Windows.Forms.Padding(4);
            this.fsBox.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.fsBox.Name = "fsBox";
            this.fsBox.Size = new System.Drawing.Size(147, 29);
            this.fsBox.TabIndex = 116;
            this.fsBox.Value = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            // 
            // label110
            // 
            this.label110.AutoSize = true;
            this.label110.Location = new System.Drawing.Point(549, 172);
            this.label110.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label110.Name = "label110";
            this.label110.Size = new System.Drawing.Size(91, 23);
            this.label110.TabIndex = 115;
            this.label110.Text = "Slip speed:";
            // 
            // fsEnable
            // 
            this.fsEnable.AutoSize = true;
            this.fsEnable.Location = new System.Drawing.Point(550, 138);
            this.fsEnable.Margin = new System.Windows.Forms.Padding(4);
            this.fsEnable.Name = "fsEnable";
            this.fsEnable.Size = new System.Drawing.Size(157, 27);
            this.fsEnable.TabIndex = 114;
            this.fsEnable.Text = "Slippery ground";
            this.fsEnable.CheckedChanged += new System.EventHandler(this.enablingCheckBox_CheckChanged);
            // 
            // lvForceMoveUse
            // 
            this.lvForceMoveUse.AutoSize = true;
            this.lvForceMoveUse.Location = new System.Drawing.Point(4, 111);
            this.lvForceMoveUse.Margin = new System.Windows.Forms.Padding(4);
            this.lvForceMoveUse.Name = "lvForceMoveUse";
            this.lvForceMoveUse.Size = new System.Drawing.Size(189, 27);
            this.lvForceMoveUse.TabIndex = 94;
            this.lvForceMoveUse.Text = "Maximal Level Limit:";
            this.lvForceMoveUse.CheckedChanged += new System.EventHandler(this.enablingCheckBox_CheckChanged);
            // 
            // lvForceMove
            // 
            this.lvForceMove.Enabled = false;
            this.lvForceMove.Location = new System.Drawing.Point(206, 108);
            this.lvForceMove.Margin = new System.Windows.Forms.Padding(4);
            this.lvForceMove.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.lvForceMove.Name = "lvForceMove";
            this.lvForceMove.Size = new System.Drawing.Size(238, 29);
            this.lvForceMove.TabIndex = 93;
            // 
            // streetNameBox
            // 
            this.streetNameBox.Enabled = false;
            this.streetNameBox.Location = new System.Drawing.Point(206, 382);
            this.streetNameBox.Margin = new System.Windows.Forms.Padding(4);
            this.streetNameBox.Name = "streetNameBox";
            this.streetNameBox.Size = new System.Drawing.Size(238, 29);
            this.streetNameBox.TabIndex = 92;
            // 
            // effectEnable
            // 
            this.effectEnable.AutoSize = true;
            this.effectEnable.Location = new System.Drawing.Point(4, 428);
            this.effectEnable.Margin = new System.Windows.Forms.Padding(4);
            this.effectEnable.Name = "effectEnable";
            this.effectEnable.Size = new System.Drawing.Size(82, 27);
            this.effectEnable.TabIndex = 91;
            this.effectEnable.Text = "Effect:";
            this.effectEnable.CheckedChanged += new System.EventHandler(this.enablingCheckBox_CheckChanged);
            // 
            // streetNameEnable
            // 
            this.streetNameEnable.AutoSize = true;
            this.streetNameEnable.Location = new System.Drawing.Point(4, 387);
            this.streetNameEnable.Margin = new System.Windows.Forms.Padding(4);
            this.streetNameEnable.Name = "streetNameEnable";
            this.streetNameEnable.Size = new System.Drawing.Size(135, 27);
            this.streetNameEnable.TabIndex = 90;
            this.streetNameEnable.Text = "Street Name:";
            this.streetNameEnable.CheckedChanged += new System.EventHandler(this.enablingCheckBox_CheckChanged);
            // 
            // mapDescEnable
            // 
            this.mapDescEnable.AutoSize = true;
            this.mapDescEnable.Location = new System.Drawing.Point(4, 348);
            this.mapDescEnable.Margin = new System.Windows.Forms.Padding(4);
            this.mapDescEnable.Name = "mapDescEnable";
            this.mapDescEnable.Size = new System.Drawing.Size(165, 27);
            this.mapDescEnable.TabIndex = 89;
            this.mapDescEnable.Text = "Map Description:";
            this.mapDescEnable.CheckedChanged += new System.EventHandler(this.enablingCheckBox_CheckChanged);
            // 
            // mapNameEnable
            // 
            this.mapNameEnable.AutoSize = true;
            this.mapNameEnable.Location = new System.Drawing.Point(4, 309);
            this.mapNameEnable.Margin = new System.Windows.Forms.Padding(4);
            this.mapNameEnable.Name = "mapNameEnable";
            this.mapNameEnable.Size = new System.Drawing.Size(125, 27);
            this.mapNameEnable.TabIndex = 88;
            this.mapNameEnable.Text = "Map Name:";
            this.mapNameEnable.CheckedChanged += new System.EventHandler(this.enablingCheckBox_CheckChanged);
            // 
            // moveLimitEnable
            // 
            this.moveLimitEnable.AutoSize = true;
            this.moveLimitEnable.Location = new System.Drawing.Point(4, 268);
            this.moveLimitEnable.Margin = new System.Windows.Forms.Padding(4);
            this.moveLimitEnable.Name = "moveLimitEnable";
            this.moveLimitEnable.Size = new System.Drawing.Size(120, 27);
            this.moveLimitEnable.TabIndex = 87;
            this.moveLimitEnable.Text = "Move limit:";
            this.moveLimitEnable.CheckedChanged += new System.EventHandler(this.enablingCheckBox_CheckChanged);
            // 
            // fieldTypeEnable
            // 
            this.fieldTypeEnable.AutoSize = true;
            this.fieldTypeEnable.Location = new System.Drawing.Point(4, 230);
            this.fieldTypeEnable.Margin = new System.Windows.Forms.Padding(4);
            this.fieldTypeEnable.Name = "fieldTypeEnable";
            this.fieldTypeEnable.Size = new System.Drawing.Size(113, 27);
            this.fieldTypeEnable.TabIndex = 86;
            this.fieldTypeEnable.Text = "Field type:";
            this.fieldTypeEnable.CheckedChanged += new System.EventHandler(this.enablingCheckBox_CheckChanged);
            // 
            // userEnterEnable
            // 
            this.userEnterEnable.AutoSize = true;
            this.userEnterEnable.Location = new System.Drawing.Point(4, 189);
            this.userEnterEnable.Margin = new System.Windows.Forms.Padding(4);
            this.userEnterEnable.Name = "userEnterEnable";
            this.userEnterEnable.Size = new System.Drawing.Size(190, 27);
            this.userEnterEnable.TabIndex = 85;
            this.userEnterEnable.Text = "Script on user enter:";
            this.userEnterEnable.CheckedChanged += new System.EventHandler(this.enablingCheckBox_CheckChanged);
            // 
            // firstUserEnable
            // 
            this.firstUserEnable.AutoSize = true;
            this.firstUserEnable.Location = new System.Drawing.Point(4, 150);
            this.firstUserEnable.Margin = new System.Windows.Forms.Padding(4);
            this.firstUserEnable.Name = "firstUserEnable";
            this.firstUserEnable.Size = new System.Drawing.Size(178, 27);
            this.firstUserEnable.TabIndex = 84;
            this.firstUserEnable.Text = "Script on first user:";
            this.firstUserEnable.CheckedChanged += new System.EventHandler(this.enablingCheckBox_CheckChanged);
            // 
            // lvLimitEnable
            // 
            this.lvLimitEnable.AutoSize = true;
            this.lvLimitEnable.Location = new System.Drawing.Point(4, 75);
            this.lvLimitEnable.Margin = new System.Windows.Forms.Padding(4);
            this.lvLimitEnable.Name = "lvLimitEnable";
            this.lvLimitEnable.Size = new System.Drawing.Size(186, 27);
            this.lvLimitEnable.TabIndex = 83;
            this.lvLimitEnable.Text = "Minimal Level Limit:";
            this.lvLimitEnable.CheckedChanged += new System.EventHandler(this.enablingCheckBox_CheckChanged);
            // 
            // timeLimitEnable
            // 
            this.timeLimitEnable.AutoSize = true;
            this.timeLimitEnable.Location = new System.Drawing.Point(4, 36);
            this.timeLimitEnable.Margin = new System.Windows.Forms.Padding(4);
            this.timeLimitEnable.Name = "timeLimitEnable";
            this.timeLimitEnable.Size = new System.Drawing.Size(195, 27);
            this.timeLimitEnable.TabIndex = 82;
            this.timeLimitEnable.Text = "Time Limit (seconds):";
            this.timeLimitEnable.CheckedChanged += new System.EventHandler(this.enablingCheckBox_CheckChanged);
            // 
            // effectBox
            // 
            this.effectBox.Enabled = false;
            this.effectBox.Location = new System.Drawing.Point(206, 422);
            this.effectBox.Margin = new System.Windows.Forms.Padding(4);
            this.effectBox.Name = "effectBox";
            this.effectBox.Size = new System.Drawing.Size(238, 29);
            this.effectBox.TabIndex = 80;
            // 
            // reactorNameShuffle
            // 
            this.reactorNameShuffle.AutoSize = true;
            this.reactorNameShuffle.Enabled = false;
            this.reactorNameShuffle.Location = new System.Drawing.Point(578, 68);
            this.reactorNameShuffle.Margin = new System.Windows.Forms.Padding(4);
            this.reactorNameShuffle.Name = "reactorNameShuffle";
            this.reactorNameShuffle.Size = new System.Drawing.Size(385, 27);
            this.reactorNameShuffle.TabIndex = 78;
            this.reactorNameShuffle.Text = "Only shuffle reactors with the following name:";
            this.reactorNameShuffle.CheckedChanged += new System.EventHandler(this.enablingCheckBox_CheckChanged);
            // 
            // reactorNameBox
            // 
            this.reactorNameBox.Enabled = false;
            this.reactorNameBox.Location = new System.Drawing.Point(608, 99);
            this.reactorNameBox.Margin = new System.Windows.Forms.Padding(4);
            this.reactorNameBox.Name = "reactorNameBox";
            this.reactorNameBox.Size = new System.Drawing.Size(236, 29);
            this.reactorNameBox.TabIndex = 76;
            // 
            // reactorShuffle
            // 
            this.reactorShuffle.AutoSize = true;
            this.reactorShuffle.Location = new System.Drawing.Point(552, 36);
            this.reactorShuffle.Margin = new System.Windows.Forms.Padding(4);
            this.reactorShuffle.Name = "reactorShuffle";
            this.reactorShuffle.Size = new System.Drawing.Size(158, 27);
            this.reactorShuffle.TabIndex = 75;
            this.reactorShuffle.Text = "Shuffle Reactors";
            this.reactorShuffle.CheckedChanged += new System.EventHandler(this.enablingCheckBox_CheckChanged);
            // 
            // fieldType
            // 
            this.fieldType.Enabled = false;
            this.fieldType.FormattingEnabled = true;
            this.fieldType.Items.AddRange(new object[] {
            "Default (0)",
            "Snowball (1)",
            "Continent Move (2)",
            "Tournament (3)",
            "Coconut (4)",
            "OX Quiz (5)",
            "Personal Time Limit (6)",
            "Waiting Room (7)",
            "Guild Boss (8)",
            "Limited View (9)",
            "Monster Carnival (A)",
            "Monster Carnival Revive (B)",
            "Zakum (C)",
            "Ariant Coliseum (D)",
            "Mu Lung Dojo (E)",
            "Monster Carnival 2 (F)",
            "Monster Carnival Waiting Room (10)",
            "Cookie House (11)",
            "Balrog (12)",
            "Sheep VS Wolf (13)",
            "Space Gaga (14)",
            "Witch Tower (15)",
            "Aran Tutorial (16)",
            "Mob Massacre (17)",
            "Mob Massacre Result (18)",
            "Party Raid (19)",
            "Party Raid Boss (1A)",
            "Party Raid Result (1B)",
            "No Dragon (1C)",
            "Dyanamic Foothold (1D)",
            "Escort (1E)",
            "Escort Result (1F)",
            "Hunting Ad Balloon (20)",
            "Chaos Zakum (21)",
            "Kill Count (22)",
            "Wedding (3C)",
            "Wedding Photo (3D)",
            "Fishing King (4A)",
            "Showa Bath (51h)",
            "Begginer Camp (52h)",
            "Snowman (1000d)",
            "Showa Spa (1001d)",
            "Horntail PQ (1013d)",
            "Crimsonwood PQ (1014d)"});
            this.fieldType.Location = new System.Drawing.Point(206, 225);
            this.fieldType.Margin = new System.Windows.Forms.Padding(4);
            this.fieldType.Name = "fieldType";
            this.fieldType.Size = new System.Drawing.Size(236, 31);
            this.fieldType.TabIndex = 72;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 717);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(1074, 23);
            this.label14.TabIndex = 71;
            this.label14.Text = "NOTE: Move limit is not related to field limit, and neither are street\\map name a" +
    "nd map description related to the ones in essential settings.";
            // 
            // mapName
            // 
            this.mapName.Enabled = false;
            this.mapName.Location = new System.Drawing.Point(206, 304);
            this.mapName.Margin = new System.Windows.Forms.Padding(4);
            this.mapName.Name = "mapName";
            this.mapName.Size = new System.Drawing.Size(238, 29);
            this.mapName.TabIndex = 70;
            // 
            // timeLimit
            // 
            this.timeLimit.Enabled = false;
            this.timeLimit.Location = new System.Drawing.Point(206, 33);
            this.timeLimit.Margin = new System.Windows.Forms.Padding(4);
            this.timeLimit.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.timeLimit.Name = "timeLimit";
            this.timeLimit.Size = new System.Drawing.Size(238, 29);
            this.timeLimit.TabIndex = 56;
            // 
            // moveLimit
            // 
            this.moveLimit.Enabled = false;
            this.moveLimit.Location = new System.Drawing.Point(206, 266);
            this.moveLimit.Margin = new System.Windows.Forms.Padding(4);
            this.moveLimit.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.moveLimit.Name = "moveLimit";
            this.moveLimit.Size = new System.Drawing.Size(240, 29);
            this.moveLimit.TabIndex = 66;
            // 
            // lvLimit
            // 
            this.lvLimit.Enabled = false;
            this.lvLimit.Location = new System.Drawing.Point(206, 72);
            this.lvLimit.Margin = new System.Windows.Forms.Padding(4);
            this.lvLimit.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.lvLimit.Name = "lvLimit";
            this.lvLimit.Size = new System.Drawing.Size(238, 29);
            this.lvLimit.TabIndex = 58;
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage5.Controls.Add(this.summonMobEnable);
            this.tabPage5.Controls.Add(this.allowedItemsRemove);
            this.tabPage5.Controls.Add(this.allowedItemsAdd);
            this.tabPage5.Controls.Add(this.allowedItems);
            this.tabPage5.Controls.Add(this.allowedItemsEnable);
            this.tabPage5.Controls.Add(this.label114);
            this.tabPage5.Controls.Add(this.autoLieProp);
            this.tabPage5.Controls.Add(this.label16);
            this.tabPage5.Controls.Add(this.autoLieInterval);
            this.tabPage5.Controls.Add(this.label17);
            this.tabPage5.Controls.Add(this.autoLieEnd);
            this.tabPage5.Controls.Add(this.label18);
            this.tabPage5.Controls.Add(this.autoLieStart);
            this.tabPage5.Controls.Add(this.label19);
            this.tabPage5.Controls.Add(this.autoLieDetectorEnable);
            this.tabPage5.Controls.Add(this.timedMobMessage);
            this.tabPage5.Controls.Add(this.label125);
            this.tabPage5.Controls.Add(this.timedMobId);
            this.tabPage5.Controls.Add(this.label124);
            this.tabPage5.Controls.Add(this.timedMobEnd);
            this.tabPage5.Controls.Add(this.label12);
            this.tabPage5.Controls.Add(this.timedMobStart);
            this.tabPage5.Controls.Add(this.label121);
            this.tabPage5.Controls.Add(this.timedMobEnable);
            this.tabPage5.Location = new System.Drawing.Point(4, 32);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(1162, 752);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Structured Optional Settings";
            // 
            // summonMobEnable
            // 
            this.summonMobEnable.AutoSize = true;
            this.summonMobEnable.Location = new System.Drawing.Point(24, 30);
            this.summonMobEnable.Margin = new System.Windows.Forms.Padding(4);
            this.summonMobEnable.Name = "summonMobEnable";
            this.summonMobEnable.Size = new System.Drawing.Size(145, 27);
            this.summonMobEnable.TabIndex = 175;
            this.summonMobEnable.Text = "Summon mob";
            this.summonMobEnable.CheckedChanged += new System.EventHandler(this.enablingCheckBox_CheckChanged);
            // 
            // allowedItemsRemove
            // 
            this.allowedItemsRemove.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.allowedItemsRemove.Enabled = false;
            this.allowedItemsRemove.Location = new System.Drawing.Point(168, 678);
            this.allowedItemsRemove.Margin = new System.Windows.Forms.Padding(4);
            this.allowedItemsRemove.Name = "allowedItemsRemove";
            this.allowedItemsRemove.Size = new System.Drawing.Size(104, 32);
            this.allowedItemsRemove.TabIndex = 153;
            this.allowedItemsRemove.Text = "Remove item";
            this.allowedItemsRemove.Click += new System.EventHandler(this.allowedItemsRemove_Click);
            // 
            // allowedItemsAdd
            // 
            this.allowedItemsAdd.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.allowedItemsAdd.Enabled = false;
            this.allowedItemsAdd.Location = new System.Drawing.Point(52, 678);
            this.allowedItemsAdd.Margin = new System.Windows.Forms.Padding(4);
            this.allowedItemsAdd.Name = "allowedItemsAdd";
            this.allowedItemsAdd.Size = new System.Drawing.Size(106, 32);
            this.allowedItemsAdd.TabIndex = 152;
            this.allowedItemsAdd.Text = "Add item";
            this.allowedItemsAdd.Click += new System.EventHandler(this.allowedItemsAdd_Click);
            // 
            // allowedItems
            // 
            this.allowedItems.Enabled = false;
            this.allowedItems.FormattingEnabled = true;
            this.allowedItems.ItemHeight = 23;
            this.allowedItems.Location = new System.Drawing.Point(52, 566);
            this.allowedItems.Margin = new System.Windows.Forms.Padding(4);
            this.allowedItems.Name = "allowedItems";
            this.allowedItems.Size = new System.Drawing.Size(217, 96);
            this.allowedItems.TabIndex = 151;
            // 
            // allowedItemsEnable
            // 
            this.allowedItemsEnable.AutoSize = true;
            this.allowedItemsEnable.Location = new System.Drawing.Point(24, 534);
            this.allowedItemsEnable.Margin = new System.Windows.Forms.Padding(4);
            this.allowedItemsEnable.Name = "allowedItemsEnable";
            this.allowedItemsEnable.Size = new System.Drawing.Size(142, 27);
            this.allowedItemsEnable.TabIndex = 150;
            this.allowedItemsEnable.Text = "Allowed items";
            this.allowedItemsEnable.CheckedChanged += new System.EventHandler(this.enablingCheckBox_CheckChanged);
            // 
            // label114
            // 
            this.label114.AutoSize = true;
            this.label114.Location = new System.Drawing.Point(9, 0);
            this.label114.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label114.Name = "label114";
            this.label114.Size = new System.Drawing.Size(395, 23);
            this.label114.TabIndex = 149;
            this.label114.Text = " (even more do not touch if you don\'t understand)";
            // 
            // autoLieProp
            // 
            this.autoLieProp.Enabled = false;
            this.autoLieProp.Location = new System.Drawing.Point(272, 495);
            this.autoLieProp.Margin = new System.Windows.Forms.Padding(4);
            this.autoLieProp.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.autoLieProp.Name = "autoLieProp";
            this.autoLieProp.Size = new System.Drawing.Size(104, 29);
            this.autoLieProp.TabIndex = 143;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(158, 500);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(91, 23);
            this.label16.TabIndex = 142;
            this.label16.Text = "Probability";
            // 
            // autoLieInterval
            // 
            this.autoLieInterval.Enabled = false;
            this.autoLieInterval.Location = new System.Drawing.Point(272, 456);
            this.autoLieInterval.Margin = new System.Windows.Forms.Padding(4);
            this.autoLieInterval.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.autoLieInterval.Name = "autoLieInterval";
            this.autoLieInterval.Size = new System.Drawing.Size(104, 29);
            this.autoLieInterval.TabIndex = 141;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(106, 459);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(143, 23);
            this.label17.TabIndex = 140;
            this.label17.Text = "Interval (Minutes)";
            // 
            // autoLieEnd
            // 
            this.autoLieEnd.Enabled = false;
            this.autoLieEnd.Location = new System.Drawing.Point(272, 420);
            this.autoLieEnd.Margin = new System.Windows.Forms.Padding(4);
            this.autoLieEnd.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.autoLieEnd.Name = "autoLieEnd";
            this.autoLieEnd.Size = new System.Drawing.Size(104, 29);
            this.autoLieEnd.TabIndex = 139;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(27, 423);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(217, 23);
            this.label18.TabIndex = 138;
            this.label18.Text = "End (ONLY hour, 24h clock)";
            // 
            // autoLieStart
            // 
            this.autoLieStart.Enabled = false;
            this.autoLieStart.Location = new System.Drawing.Point(272, 381);
            this.autoLieStart.Margin = new System.Windows.Forms.Padding(4);
            this.autoLieStart.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.autoLieStart.Name = "autoLieStart";
            this.autoLieStart.Size = new System.Drawing.Size(104, 29);
            this.autoLieStart.TabIndex = 137;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(24, 384);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(223, 23);
            this.label19.TabIndex = 136;
            this.label19.Text = "Start (ONLY hour, 24h clock)";
            // 
            // autoLieDetectorEnable
            // 
            this.autoLieDetectorEnable.AutoSize = true;
            this.autoLieDetectorEnable.Location = new System.Drawing.Point(24, 350);
            this.autoLieDetectorEnable.Margin = new System.Windows.Forms.Padding(4);
            this.autoLieDetectorEnable.Name = "autoLieDetectorEnable";
            this.autoLieDetectorEnable.Size = new System.Drawing.Size(263, 27);
            this.autoLieDetectorEnable.TabIndex = 135;
            this.autoLieDetectorEnable.Text = "Use an automatic lie-detector";
            this.autoLieDetectorEnable.CheckedChanged += new System.EventHandler(this.enablingCheckBox_CheckChanged);
            // 
            // timedMobMessage
            // 
            this.timedMobMessage.AcceptsReturn = true;
            this.timedMobMessage.Enabled = false;
            this.timedMobMessage.Location = new System.Drawing.Point(88, 202);
            this.timedMobMessage.Margin = new System.Windows.Forms.Padding(4);
            this.timedMobMessage.Multiline = true;
            this.timedMobMessage.Name = "timedMobMessage";
            this.timedMobMessage.Size = new System.Drawing.Size(362, 130);
            this.timedMobMessage.TabIndex = 134;
            // 
            // label125
            // 
            this.label125.AutoSize = true;
            this.label125.Location = new System.Drawing.Point(9, 200);
            this.label125.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label125.Name = "label125";
            this.label125.Size = new System.Drawing.Size(80, 23);
            this.label125.TabIndex = 133;
            this.label125.Text = "Message:";
            // 
            // timedMobId
            // 
            this.timedMobId.Enabled = false;
            this.timedMobId.Location = new System.Drawing.Point(88, 164);
            this.timedMobId.Margin = new System.Windows.Forms.Padding(4);
            this.timedMobId.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.timedMobId.Name = "timedMobId";
            this.timedMobId.Size = new System.Drawing.Size(183, 29);
            this.timedMobId.TabIndex = 131;
            // 
            // label124
            // 
            this.label124.AutoSize = true;
            this.label124.Location = new System.Drawing.Point(22, 168);
            this.label124.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label124.Name = "label124";
            this.label124.Size = new System.Drawing.Size(67, 23);
            this.label124.TabIndex = 130;
            this.label124.Text = "Mob ID";
            // 
            // timedMobEnd
            // 
            this.timedMobEnd.Enabled = false;
            this.timedMobEnd.Location = new System.Drawing.Point(312, 129);
            this.timedMobEnd.Margin = new System.Windows.Forms.Padding(4);
            this.timedMobEnd.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.timedMobEnd.Name = "timedMobEnd";
            this.timedMobEnd.Size = new System.Drawing.Size(104, 29);
            this.timedMobEnd.TabIndex = 129;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(92, 132);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(217, 23);
            this.label12.TabIndex = 128;
            this.label12.Text = "End (ONLY hour, 24h clock)";
            // 
            // timedMobStart
            // 
            this.timedMobStart.Enabled = false;
            this.timedMobStart.Location = new System.Drawing.Point(312, 90);
            this.timedMobStart.Margin = new System.Windows.Forms.Padding(4);
            this.timedMobStart.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.timedMobStart.Name = "timedMobStart";
            this.timedMobStart.Size = new System.Drawing.Size(104, 29);
            this.timedMobStart.TabIndex = 127;
            // 
            // label121
            // 
            this.label121.AutoSize = true;
            this.label121.Location = new System.Drawing.Point(88, 93);
            this.label121.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label121.Name = "label121";
            this.label121.Size = new System.Drawing.Size(223, 23);
            this.label121.TabIndex = 126;
            this.label121.Text = "Start (ONLY hour, 24h clock)";
            // 
            // timedMobEnable
            // 
            this.timedMobEnable.AutoSize = true;
            this.timedMobEnable.Location = new System.Drawing.Point(88, 62);
            this.timedMobEnable.Margin = new System.Windows.Forms.Padding(4);
            this.timedMobEnable.Name = "timedMobEnable";
            this.timedMobEnable.Size = new System.Drawing.Size(123, 27);
            this.timedMobEnable.TabIndex = 125;
            this.timedMobEnable.Text = "Timed mob";
            this.timedMobEnable.CheckedChanged += new System.EventHandler(this.enablingCheckBox_CheckChanged);
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage4.Controls.Add(this.fieldLimitPanel1);
            this.tabPage4.Controls.Add(this.optionsList);
            this.tabPage4.Controls.Add(this.label5);
            this.tabPage4.Controls.Add(this.unknownProps);
            this.tabPage4.Controls.Add(this.label24);
            this.tabPage4.Controls.Add(this.label10);
            this.tabPage4.Location = new System.Drawing.Point(4, 32);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1162, 752);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Other Settings";
            // 
            // fieldLimitPanel1
            // 
            this.fieldLimitPanel1.FieldLimit = ((ulong)(0ul));
            this.fieldLimitPanel1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.fieldLimitPanel1.Location = new System.Drawing.Point(266, 36);
            this.fieldLimitPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.fieldLimitPanel1.Name = "fieldLimitPanel1";
            this.fieldLimitPanel1.Size = new System.Drawing.Size(508, 699);
            this.fieldLimitPanel1.TabIndex = 72;
            // 
            // optionsList
            // 
            this.optionsList.AutoCheck = true;
            this.optionsList.CheckMember = null;
            this.optionsList.CheckOnClick = true;
            this.optionsList.FormattingEnabled = true;
            this.optionsList.Items.AddRange(new object[] {
            "Clouds",
            "Snow",
            "Rain",
            "Swim",
            "Fly",
            "Town",
            "Party Only",
            "Expedition Only",
            "No Map Commands",
            "Hide Minimap",
            "Minimap On\\Off",
            "Personal Shops",
            "Entrusted Shops",
            "No Regeneration",
            "Block P-Boss Change",
            "Everlast",
            "Damage-Check Free",
            "Disable Scrolls",
            "Skill Needed to Fly",
            "Zakum-2 JQ Anti-Hack",
            "Check All Moves (Anti-Hack)",
            "Use VR as Limits",
            "Mirror Bottom (Reflection)"});
            this.optionsList.Location = new System.Drawing.Point(9, 36);
            this.optionsList.Margin = new System.Windows.Forms.Padding(4);
            this.optionsList.Name = "optionsList";
            this.optionsList.Size = new System.Drawing.Size(246, 680);
            this.optionsList.TabIndex = 43;
            // 
            // label123
            // 
            this.label123.Location = new System.Drawing.Point(0, 0);
            this.label123.Name = "label123";
            this.label123.Size = new System.Drawing.Size(100, 23);
            this.label123.TabIndex = 0;
            // 
            // okButton
            // 
            this.okButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.okButton.Location = new System.Drawing.Point(538, 800);
            this.okButton.Margin = new System.Windows.Forms.Padding(4);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(123, 42);
            this.okButton.TabIndex = 72;
            this.okButton.Text = "OK";
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.cancelButton.Location = new System.Drawing.Point(670, 800);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(123, 42);
            this.cancelButton.TabIndex = 73;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // InfoEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1191, 860);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.tabControl1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "InfoEditor";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Map Info";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InfoEditor_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mobRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.forcedRet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.markImage)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recovery)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dropRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.protectItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.decInterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.decHP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dropExpire)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fixedMobCapacity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.createMobInterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fsBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lvForceMove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moveLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lvLimit)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.autoLieProp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoLieInterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoLieEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoLieStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timedMobId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timedMobEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timedMobStart)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox bgmBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox streetBox;
        private System.Windows.Forms.PictureBox markImage;
        private System.Windows.Forms.ComboBox markBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown returnBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown forcedRet;
        private System.Windows.Forms.Label label9;
        private HaCreator.CustomControls.BetterCheckedListBox optionsList;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown timeLimit;
        private System.Windows.Forms.NumericUpDown lvLimit;
        private System.Windows.Forms.TextBox firstUserEnter;
        private System.Windows.Forms.TextBox userEnter;
        private System.Windows.Forms.NumericUpDown moveLimit;
        private System.Windows.Forms.TextBox mapDesc;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TreeView unknownProps;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TextBox mapName;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox fieldType;
        private System.Windows.Forms.NumericUpDown mobRate;
        private System.Windows.Forms.CheckBox reactorNameShuffle;
        private System.Windows.Forms.TextBox reactorNameBox;
        private System.Windows.Forms.CheckBox reactorShuffle;
        private System.Windows.Forms.CheckBox effectEnable;
        private System.Windows.Forms.CheckBox streetNameEnable;
        private System.Windows.Forms.CheckBox mapDescEnable;
        private System.Windows.Forms.CheckBox mapNameEnable;
        private System.Windows.Forms.CheckBox moveLimitEnable;
        private System.Windows.Forms.CheckBox fieldTypeEnable;
        private System.Windows.Forms.CheckBox userEnterEnable;
        private System.Windows.Forms.CheckBox firstUserEnable;
        private System.Windows.Forms.CheckBox lvLimitEnable;
        private System.Windows.Forms.CheckBox timeLimitEnable;
        private System.Windows.Forms.Label label123;
        private System.Windows.Forms.TextBox effectBox;
        private System.Windows.Forms.TextBox streetNameBox;
        private System.Windows.Forms.CheckBox lvForceMoveUse;
        private System.Windows.Forms.NumericUpDown lvForceMove;
        private System.Windows.Forms.NumericUpDown fsBox;
        private System.Windows.Forms.Label label110;
        private System.Windows.Forms.CheckBox fsEnable;
        private System.Windows.Forms.CheckBox autoLieDetectorEnable;
        private System.Windows.Forms.NumericUpDown timedMobStart;
        private System.Windows.Forms.TextBox timedMobMessage;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Label label114;
        private System.Windows.Forms.NumericUpDown autoLieProp;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.NumericUpDown autoLieInterval;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.NumericUpDown autoLieEnd;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.NumericUpDown autoLieStart;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label125;
        private System.Windows.Forms.NumericUpDown timedMobId;
        private System.Windows.Forms.Label label124;
        private System.Windows.Forms.NumericUpDown timedMobEnd;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label121;
        private System.Windows.Forms.CheckBox timedMobEnable;
        private System.Windows.Forms.Label label113;
        private System.Windows.Forms.NumericUpDown fixedMobCapacity;
        private System.Windows.Forms.Label label112;
        private System.Windows.Forms.NumericUpDown createMobInterval;
        private System.Windows.Forms.CheckBox massEnable;
        private System.Windows.Forms.CheckBox helpEnable;
        private System.Windows.Forms.TextBox helpBox;
        private System.Windows.Forms.NumericUpDown dropExpire;
        private System.Windows.Forms.CheckBox dropExpireEnable;
        private System.Windows.Forms.CheckBox hpDecEnable;
        private System.Windows.Forms.NumericUpDown decHP;
        private System.Windows.Forms.Label label116;
        private System.Windows.Forms.NumericUpDown decInterval;
        private System.Windows.Forms.CheckBox decIntervalEnable;
        private System.Windows.Forms.CheckBox protectEnable;
        private System.Windows.Forms.NumericUpDown protectItem;
        private System.Windows.Forms.NumericUpDown dropRate;
        private System.Windows.Forms.CheckBox dropRateEnable;
        private System.Windows.Forms.CheckBox recoveryEnable;
        private System.Windows.Forms.CheckBox allowedItemsEnable;
        private System.Windows.Forms.ListBox allowedItems;
        private System.Windows.Forms.Button allowedItemsRemove;
        private System.Windows.Forms.Button allowedItemsAdd;
        private System.Windows.Forms.NumericUpDown recovery;
        private System.Windows.Forms.CheckBox summonMobEnable;
        private System.Windows.Forms.CheckBox returnHereCBX;
        private System.Windows.Forms.CheckBox cannotReturnCBX;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox categoryBox;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.NumericUpDown xBox;
        private System.Windows.Forms.NumericUpDown yBox;
        private FieldLimitPanel fieldLimitPanel1;
        private System.Windows.Forms.Button button_selectForcedReturnMap;
        private System.Windows.Forms.Button button_selectReturnMap;
        private System.Windows.Forms.Integration.ElementHost elementHost1;
        private SoundPlayer soundPlayer1;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
    }
}