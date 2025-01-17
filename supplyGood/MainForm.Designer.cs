﻿namespace supplyGood
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.managementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suppliesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goodsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.storagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.прогнозToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.predictGoodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statisticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.priceListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblMain = new System.Windows.Forms.Label();
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.mainDBDataSet = new supplyGood.MainDBDataSet();
            this.contextDGV = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.detailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnFunc = new System.Windows.Forms.Button();
            this.lblHint = new System.Windows.Forms.Label();
            this.btnSort = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cbxSearch = new System.Windows.Forms.ComboBox();
            this.bnMain = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnClearFilters = new System.Windows.Forms.Button();
            this.employeeTableAdapter = new supplyGood.MainDBDataSetTableAdapters.EmployeeTableAdapter();
            this.personalInfoTableAdapter = new supplyGood.MainDBDataSetTableAdapters.PersonalInfoTableAdapter();
            this.goodTableAdapter = new supplyGood.MainDBDataSetTableAdapters.GoodTableAdapter();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userTableAdapter = new supplyGood.MainDBDataSetTableAdapters.UserTableAdapter();
            this.carBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.goodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.supplyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.supplyUFTableAdapter = new supplyGood.MainDBDataSetTableAdapters.SupplyUFTableAdapter();
            this.carUFTableAdapter = new supplyGood.MainDBDataSetTableAdapters.CarUFTableAdapter();
            this.supplyTableAdapter = new supplyGood.MainDBDataSetTableAdapters.SupplyTableAdapter();
            this.carTableAdapter = new supplyGood.MainDBDataSetTableAdapters.CarTableAdapter();
            this.storageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.storageTableAdapter = new supplyGood.MainDBDataSetTableAdapters.StorageTableAdapter();
            this.storageUFTableAdapter = new supplyGood.MainDBDataSetTableAdapters.StorageUFTableAdapter();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientTableAdapter = new supplyGood.MainDBDataSetTableAdapters.ClientTableAdapter();
            this.pictureMain = new System.Windows.Forms.PictureBox();
            this.btnSearchPrev = new System.Windows.Forms.Button();
            this.btnSearchNext = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mainMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDBDataSet)).BeginInit();
            this.contextDGV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bnMain)).BeginInit();
            this.bnMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.BackColor = System.Drawing.SystemColors.Control;
            this.mainMenuStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mainMenuStrip.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainMenuStrip.GripMargin = new System.Windows.Forms.Padding(0);
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.managementToolStripMenuItem,
            this.usersToolStripMenuItem,
            this.прогнозToolStripMenuItem,
            this.statisticsToolStripMenuItem,
            this.printToolStripMenuItem});
            this.mainMenuStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.mainMenuStrip.Size = new System.Drawing.Size(1094, 28);
            this.mainMenuStrip.TabIndex = 0;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.returnToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Image = global::supplyGood.Properties.Resources.file;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.fileToolStripMenuItem.Text = "Файл";
            // 
            // returnToolStripMenuItem
            // 
            this.returnToolStripMenuItem.Image = global::supplyGood.Properties.Resources.exit;
            this.returnToolStripMenuItem.Name = "returnToolStripMenuItem";
            this.returnToolStripMenuItem.Size = new System.Drawing.Size(255, 24);
            this.returnToolStripMenuItem.Text = "Выход из учетной записи";
            this.returnToolStripMenuItem.Click += new System.EventHandler(this.ReturnToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::supplyGood.Properties.Resources._return;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(255, 24);
            this.exitToolStripMenuItem.Text = "Выход";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // managementToolStripMenuItem
            // 
            this.managementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.suppliesToolStripMenuItem,
            this.employeeToolStripMenuItem,
            this.goodsToolStripMenuItem,
            this.clientsToolStripMenuItem,
            this.storagesToolStripMenuItem,
            this.carsToolStripMenuItem});
            this.managementToolStripMenuItem.Image = global::supplyGood.Properties.Resources.view;
            this.managementToolStripMenuItem.Name = "managementToolStripMenuItem";
            this.managementToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.managementToolStripMenuItem.Text = "Просмотр";
            // 
            // suppliesToolStripMenuItem
            // 
            this.suppliesToolStripMenuItem.Image = global::supplyGood.Properties.Resources.supply;
            this.suppliesToolStripMenuItem.Name = "suppliesToolStripMenuItem";
            this.suppliesToolStripMenuItem.Size = new System.Drawing.Size(160, 24);
            this.suppliesToolStripMenuItem.Text = "Поставки";
            this.suppliesToolStripMenuItem.Click += new System.EventHandler(this.SuppliesToolStripMenuItem_Click);
            // 
            // employeeToolStripMenuItem
            // 
            this.employeeToolStripMenuItem.Image = global::supplyGood.Properties.Resources.employee;
            this.employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            this.employeeToolStripMenuItem.Size = new System.Drawing.Size(160, 24);
            this.employeeToolStripMenuItem.Text = "Сотрудники";
            this.employeeToolStripMenuItem.Click += new System.EventHandler(this.EmployeeToolStripMenuItem_Click);
            // 
            // goodsToolStripMenuItem
            // 
            this.goodsToolStripMenuItem.Image = global::supplyGood.Properties.Resources.good;
            this.goodsToolStripMenuItem.Name = "goodsToolStripMenuItem";
            this.goodsToolStripMenuItem.Size = new System.Drawing.Size(160, 24);
            this.goodsToolStripMenuItem.Text = "Товары";
            this.goodsToolStripMenuItem.Click += new System.EventHandler(this.GoodsToolStripMenuItem_Click);
            // 
            // clientsToolStripMenuItem
            // 
            this.clientsToolStripMenuItem.Image = global::supplyGood.Properties.Resources.client;
            this.clientsToolStripMenuItem.Name = "clientsToolStripMenuItem";
            this.clientsToolStripMenuItem.Size = new System.Drawing.Size(160, 24);
            this.clientsToolStripMenuItem.Text = "Заказчики";
            this.clientsToolStripMenuItem.Click += new System.EventHandler(this.ClientToolStripMenuItem_Click);
            // 
            // storagesToolStripMenuItem
            // 
            this.storagesToolStripMenuItem.Image = global::supplyGood.Properties.Resources.storage;
            this.storagesToolStripMenuItem.Name = "storagesToolStripMenuItem";
            this.storagesToolStripMenuItem.Size = new System.Drawing.Size(160, 24);
            this.storagesToolStripMenuItem.Text = "Склады";
            this.storagesToolStripMenuItem.Click += new System.EventHandler(this.StorageToolStripMenuItem_Click);
            // 
            // carsToolStripMenuItem
            // 
            this.carsToolStripMenuItem.Image = global::supplyGood.Properties.Resources.car;
            this.carsToolStripMenuItem.Name = "carsToolStripMenuItem";
            this.carsToolStripMenuItem.Size = new System.Drawing.Size(160, 24);
            this.carsToolStripMenuItem.Text = "Машины";
            this.carsToolStripMenuItem.Click += new System.EventHandler(this.CarsToolStripMenuItem_Click);
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.usersToolStripMenuItem.Image = global::supplyGood.Properties.Resources.user;
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(136, 24);
            this.usersToolStripMenuItem.Text = "Пользователи";
            this.usersToolStripMenuItem.Click += new System.EventHandler(this.UsersToolStripMenuItem_Click);
            // 
            // прогнозToolStripMenuItem
            // 
            this.прогнозToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.predictGoodToolStripMenuItem});
            this.прогнозToolStripMenuItem.Image = global::supplyGood.Properties.Resources.forecast;
            this.прогнозToolStripMenuItem.Name = "прогнозToolStripMenuItem";
            this.прогнозToolStripMenuItem.Size = new System.Drawing.Size(97, 24);
            this.прогнозToolStripMenuItem.Text = "Прогноз";
            // 
            // predictGoodToolStripMenuItem
            // 
            this.predictGoodToolStripMenuItem.Image = global::supplyGood.Properties.Resources.supplygood;
            this.predictGoodToolStripMenuItem.Name = "predictGoodToolStripMenuItem";
            this.predictGoodToolStripMenuItem.Size = new System.Drawing.Size(131, 24);
            this.predictGoodToolStripMenuItem.Text = "Товары";
            this.predictGoodToolStripMenuItem.Click += new System.EventHandler(this.PredictGoodToolStripMenuItem_Click);
            // 
            // statisticsToolStripMenuItem
            // 
            this.statisticsToolStripMenuItem.Image = global::supplyGood.Properties.Resources.statistics;
            this.statisticsToolStripMenuItem.Name = "statisticsToolStripMenuItem";
            this.statisticsToolStripMenuItem.Size = new System.Drawing.Size(112, 24);
            this.statisticsToolStripMenuItem.Text = "Статистика";
            this.statisticsToolStripMenuItem.Click += new System.EventHandler(this.statisticsToolStripMenuItem_Click);
            // 
            // печатьToolStripMenuItem
            // 
            this.printToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.priceListToolStripMenuItem});
            this.printToolStripMenuItem.Image = global::supplyGood.Properties.Resources.printer;
            this.printToolStripMenuItem.Name = "печатьToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.printToolStripMenuItem.Text = "Печать";
            // 
            // priceListToolStripMenuItem
            // 
            this.priceListToolStripMenuItem.Image = global::supplyGood.Properties.Resources.good;
            this.priceListToolStripMenuItem.Name = "priceListToolStripMenuItem";
            this.priceListToolStripMenuItem.Size = new System.Drawing.Size(158, 24);
            this.priceListToolStripMenuItem.Text = "Прайс-лист";
            this.priceListToolStripMenuItem.Click += new System.EventHandler(this.PriceListToolStripMenuItem_Click);
            // 
            // lblMain
            // 
            this.lblMain.AutoSize = true;
            this.lblMain.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMain.Location = new System.Drawing.Point(65, 36);
            this.lblMain.Name = "lblMain";
            this.lblMain.Size = new System.Drawing.Size(330, 47);
            this.lblMain.TabIndex = 3;
            this.lblMain.Text = "Выберите действие";
            // 
            // dgvMain
            // 
            this.dgvMain.AllowUserToAddRows = false;
            this.dgvMain.AllowUserToDeleteRows = false;
            this.dgvMain.AllowUserToResizeRows = false;
            this.dgvMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMain.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvMain.BackgroundColor = System.Drawing.Color.White;
            this.dgvMain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMain.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Location = new System.Drawing.Point(12, 89);
            this.dgvMain.MultiSelect = false;
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.ReadOnly = true;
            this.dgvMain.RowHeadersVisible = false;
            this.dgvMain.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvMain.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMain.ShowCellToolTips = false;
            this.dgvMain.Size = new System.Drawing.Size(1072, 452);
            this.dgvMain.TabIndex = 4;
            this.dgvMain.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvMain_CellMouseDown);
            this.dgvMain.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvMain_DataError);
            this.dgvMain.DoubleClick += new System.EventHandler(this.dgvMain_DoubleClick);
            // 
            // mainDBDataSet
            // 
            this.mainDBDataSet.DataSetName = "MainDBDataSet";
            this.mainDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // contextDGV
            // 
            this.contextDGV.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.detailsToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextDGV.Name = "cmsViewEditDelete";
            this.contextDGV.Size = new System.Drawing.Size(155, 70);
            // 
            // detailsToolStripMenuItem
            // 
            this.detailsToolStripMenuItem.Name = "detailsToolStripMenuItem";
            this.detailsToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.detailsToolStripMenuItem.Text = "Просмотреть";
            this.detailsToolStripMenuItem.Click += new System.EventHandler(this.Context_DetailsToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.editToolStripMenuItem.Text = "Редактировать";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.Context_EditToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.deleteToolStripMenuItem.Text = "Удалить";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.Context_DeleteToolStripMenuItem_Click);
            // 
            // btnFunc
            // 
            this.btnFunc.BackColor = System.Drawing.Color.Azure;
            this.btnFunc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFunc.Location = new System.Drawing.Point(846, 547);
            this.btnFunc.Name = "btnFunc";
            this.btnFunc.Size = new System.Drawing.Size(238, 48);
            this.btnFunc.TabIndex = 5;
            this.btnFunc.Text = "Добавить пользователя";
            this.btnFunc.UseVisualStyleBackColor = false;
            this.btnFunc.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // lblHint
            // 
            this.lblHint.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblHint.Location = new System.Drawing.Point(68, 547);
            this.lblHint.Name = "lblHint";
            this.lblHint.Size = new System.Drawing.Size(772, 60);
            this.lblHint.TabIndex = 11;
            this.lblHint.Text = "Подсказка";
            // 
            // btnSort
            // 
            this.btnSort.BackColor = System.Drawing.Color.LightCyan;
            this.btnSort.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSort.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSort.Location = new System.Drawing.Point(867, 31);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(217, 25);
            this.btnSort.TabIndex = 6;
            this.btnSort.Text = "Сортировка";
            this.btnSort.UseVisualStyleBackColor = false;
            this.btnSort.Click += new System.EventHandler(this.BtnSort_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtSearch.Location = new System.Drawing.Point(636, 58);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(189, 25);
            this.txtSearch.TabIndex = 17;
            // 
            // cbxSearch
            // 
            this.cbxSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbxSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbxSearch.FormattingEnabled = true;
            this.cbxSearch.Location = new System.Drawing.Point(636, 32);
            this.cbxSearch.Name = "cbxSearch";
            this.cbxSearch.Size = new System.Drawing.Size(189, 25);
            this.cbxSearch.TabIndex = 18;
            // 
            // bnMain
            // 
            this.bnMain.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bnMain.CountItem = this.bindingNavigatorCountItem;
            this.bnMain.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bnMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bnMain.Location = new System.Drawing.Point(0, 24);
            this.bnMain.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bnMain.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bnMain.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bnMain.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bnMain.Name = "bnMain";
            this.bnMain.PositionItem = this.bindingNavigatorPositionItem;
            this.bnMain.Size = new System.Drawing.Size(1094, 25);
            this.bnMain.TabIndex = 20;
            this.bnMain.Text = "bnMain";
            this.bnMain.Visible = false;
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.Color.MintCream;
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFilter.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFilter.Location = new System.Drawing.Point(867, 58);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(76, 25);
            this.btnFilter.TabIndex = 21;
            this.btnFilter.Text = "Фильтры";
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.BtnFilter_Click);
            // 
            // btnClearFilters
            // 
            this.btnClearFilters.BackColor = System.Drawing.Color.MintCream;
            this.btnClearFilters.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClearFilters.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClearFilters.Location = new System.Drawing.Point(949, 58);
            this.btnClearFilters.Name = "btnClearFilters";
            this.btnClearFilters.Size = new System.Drawing.Size(135, 25);
            this.btnClearFilters.TabIndex = 22;
            this.btnClearFilters.Text = "Очистить фильтры";
            this.btnClearFilters.UseVisualStyleBackColor = false;
            this.btnClearFilters.Click += new System.EventHandler(this.BtnClearFilters_Click);
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // personalInfoTableAdapter
            // 
            this.personalInfoTableAdapter.ClearBeforeFill = true;
            // 
            // goodTableAdapter
            // 
            this.goodTableAdapter.ClearBeforeFill = true;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataMember = "User";
            this.userBindingSource.DataSource = this.mainDBDataSet;
            // 
            // userTableAdapter
            // 
            this.userTableAdapter.ClearBeforeFill = true;
            // 
            // carBindingSource
            // 
            this.carBindingSource.DataMember = "CarUF";
            this.carBindingSource.DataSource = this.mainDBDataSet;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.mainDBDataSet;
            // 
            // goodBindingSource
            // 
            this.goodBindingSource.DataMember = "Good";
            this.goodBindingSource.DataSource = this.mainDBDataSet;
            // 
            // supplyBindingSource
            // 
            this.supplyBindingSource.DataMember = "SupplyUF";
            this.supplyBindingSource.DataSource = this.mainDBDataSet;
            // 
            // supplyUFTableAdapter
            // 
            this.supplyUFTableAdapter.ClearBeforeFill = true;
            // 
            // carUFTableAdapter
            // 
            this.carUFTableAdapter.ClearBeforeFill = true;
            // 
            // supplyTableAdapter
            // 
            this.supplyTableAdapter.ClearBeforeFill = true;
            // 
            // carTableAdapter
            // 
            this.carTableAdapter.ClearBeforeFill = true;
            // 
            // storageBindingSource
            // 
            this.storageBindingSource.DataMember = "StorageUF";
            this.storageBindingSource.DataSource = this.mainDBDataSet;
            // 
            // storageTableAdapter
            // 
            this.storageTableAdapter.ClearBeforeFill = true;
            // 
            // storageUFTableAdapter
            // 
            this.storageUFTableAdapter.ClearBeforeFill = true;
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "Client";
            this.clientBindingSource.DataSource = this.mainDBDataSet;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // pictureMain
            // 
            this.pictureMain.InitialImage = null;
            this.pictureMain.Location = new System.Drawing.Point(12, 36);
            this.pictureMain.Name = "pictureMain";
            this.pictureMain.Size = new System.Drawing.Size(47, 47);
            this.pictureMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureMain.TabIndex = 23;
            this.pictureMain.TabStop = false;
            // 
            // btnSearchPrev
            // 
            this.btnSearchPrev.BackColor = System.Drawing.Color.Honeydew;
            this.btnSearchPrev.BackgroundImage = global::supplyGood.Properties.Resources.prev;
            this.btnSearchPrev.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSearchPrev.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearchPrev.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSearchPrev.Location = new System.Drawing.Point(600, 31);
            this.btnSearchPrev.Name = "btnSearchPrev";
            this.btnSearchPrev.Size = new System.Drawing.Size(30, 52);
            this.btnSearchPrev.TabIndex = 16;
            this.btnSearchPrev.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchPrev.UseVisualStyleBackColor = false;
            this.btnSearchPrev.Click += new System.EventHandler(this.BtnSearchPrev_Click);
            // 
            // btnSearchNext
            // 
            this.btnSearchNext.BackColor = System.Drawing.Color.Honeydew;
            this.btnSearchNext.BackgroundImage = global::supplyGood.Properties.Resources.next;
            this.btnSearchNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSearchNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearchNext.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSearchNext.Location = new System.Drawing.Point(831, 31);
            this.btnSearchNext.Name = "btnSearchNext";
            this.btnSearchNext.Size = new System.Drawing.Size(30, 52);
            this.btnSearchNext.TabIndex = 15;
            this.btnSearchNext.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchNext.UseVisualStyleBackColor = false;
            this.btnSearchNext.Click += new System.EventHandler(this.BtnSearchNext_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::supplyGood.Properties.Resources.hint;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(15, 544);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1094, 616);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureMain);
            this.Controls.Add(this.btnClearFilters);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.bnMain);
            this.Controls.Add(this.cbxSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearchPrev);
            this.Controls.Add(this.btnSearchNext);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.lblHint);
            this.Controls.Add(this.btnFunc);
            this.Controls.Add(this.dgvMain);
            this.Controls.Add(this.lblMain);
            this.Controls.Add(this.mainMenuStrip);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenuStrip;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDBDataSet)).EndInit();
            this.contextDGV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bnMain)).EndInit();
            this.bnMain.ResumeLayout(false);
            this.bnMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem managementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suppliesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goodsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem storagesToolStripMenuItem;
        private System.Windows.Forms.Label lblMain;
        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.ContextMenuStrip contextDGV;
        private System.Windows.Forms.ToolStripMenuItem detailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.Button btnFunc;
        private System.Windows.Forms.Label lblHint;
        private MainDBDataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private MainDBDataSetTableAdapters.PersonalInfoTableAdapter personalInfoTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem clientsToolStripMenuItem;
        private MainDBDataSetTableAdapters.GoodTableAdapter goodTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.Button btnSort;
        private MainDBDataSet mainDBDataSet;
        private System.Windows.Forms.BindingSource userBindingSource;
        private MainDBDataSetTableAdapters.UserTableAdapter userTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem statisticsToolStripMenuItem;
        private System.Windows.Forms.Button btnSearchNext;
        private System.Windows.Forms.Button btnSearchPrev;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ToolStripMenuItem прогнозToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem predictGoodToolStripMenuItem;
        private System.Windows.Forms.BindingSource carBindingSource;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private System.Windows.Forms.BindingSource goodBindingSource;
        private System.Windows.Forms.BindingSource supplyBindingSource;
        private System.Windows.Forms.ComboBox cbxSearch;
        private System.Windows.Forms.BindingNavigator bnMain;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnClearFilters;
        private MainDBDataSetTableAdapters.SupplyUFTableAdapter supplyUFTableAdapter;
        private MainDBDataSetTableAdapters.CarUFTableAdapter carUFTableAdapter;
        private MainDBDataSetTableAdapters.SupplyTableAdapter supplyTableAdapter;
        private MainDBDataSetTableAdapters.CarTableAdapter carTableAdapter;
        private System.Windows.Forms.BindingSource storageBindingSource;
        private MainDBDataSetTableAdapters.StorageTableAdapter storageTableAdapter;
        private MainDBDataSetTableAdapters.StorageUFTableAdapter storageUFTableAdapter;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private MainDBDataSetTableAdapters.ClientTableAdapter clientTableAdapter;
        private System.Windows.Forms.PictureBox pictureMain;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem priceListToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}