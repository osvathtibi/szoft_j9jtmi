namespace ZH3_3
{
    partial class UserControlEvents
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            eventIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Name = new DataGridViewTextBoxColumn();
            eventDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            locationDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            eventsBindingSource = new BindingSource(components);
            listBox1 = new ListBox();
            buttonDel = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)eventsBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { eventIdDataGridViewTextBoxColumn, Name, eventDateDataGridViewTextBoxColumn, locationDataGridViewTextBoxColumn, descriptionDataGridViewTextBoxColumn });
            dataGridView1.DataSource = eventsBindingSource;
            dataGridView1.Location = new Point(33, 26);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(958, 314);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // eventIdDataGridViewTextBoxColumn
            // 
            eventIdDataGridViewTextBoxColumn.DataPropertyName = "EventId";
            eventIdDataGridViewTextBoxColumn.HeaderText = "EventId";
            eventIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            eventIdDataGridViewTextBoxColumn.Name = "eventIdDataGridViewTextBoxColumn";
            eventIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // Name
            // 
            Name.DataPropertyName = "Name";
            Name.HeaderText = "Name";
            Name.MinimumWidth = 6;
            Name.Name = "Name";
            Name.Width = 125;
            // 
            // eventDateDataGridViewTextBoxColumn
            // 
            eventDateDataGridViewTextBoxColumn.DataPropertyName = "EventDate";
            eventDateDataGridViewTextBoxColumn.HeaderText = "EventDate";
            eventDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            eventDateDataGridViewTextBoxColumn.Name = "eventDateDataGridViewTextBoxColumn";
            eventDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // locationDataGridViewTextBoxColumn
            // 
            locationDataGridViewTextBoxColumn.DataPropertyName = "Location";
            locationDataGridViewTextBoxColumn.HeaderText = "Location";
            locationDataGridViewTextBoxColumn.MinimumWidth = 6;
            locationDataGridViewTextBoxColumn.Name = "locationDataGridViewTextBoxColumn";
            locationDataGridViewTextBoxColumn.Width = 125;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            descriptionDataGridViewTextBoxColumn.Width = 125;
            // 
            // eventsBindingSource
            // 
            eventsBindingSource.DataSource = typeof(Models.Events);
            // 
            // listBox1
            // 
            listBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(211, 366);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(486, 144);
            listBox1.TabIndex = 1;
            // 
            // buttonDel
            // 
            buttonDel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonDel.Location = new Point(824, 72);
            buttonDel.Name = "buttonDel";
            buttonDel.Size = new Size(94, 29);
            buttonDel.TabIndex = 2;
            buttonDel.Text = "Törlés";
            buttonDel.UseVisualStyleBackColor = true;
            buttonDel.Click += buttonDel_Click;
            // 
            // UserControlEvents
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            Controls.Add(buttonDel);
            Controls.Add(listBox1);
            Controls.Add(dataGridView1);
            Size = new Size(1015, 523);
            Load += UserControlEvents_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)eventsBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private BindingSource eventsBindingSource;
        private ListBox listBox1;
        private DataGridViewTextBoxColumn eventIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn eventDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private Button buttonDel;
    }
}
