namespace ZH3_3
{
    partial class UserControlEAP
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
            kapcsolatIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            eventIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            participantIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            EventName = new DataGridViewComboBoxColumn();
            eventsBindingSource = new BindingSource(components);
            ParticipantName = new DataGridViewComboBoxColumn();
            participantsBindingSource = new BindingSource(components);
            eventParticipantsBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)eventsBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)participantsBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)eventParticipantsBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { kapcsolatIdDataGridViewTextBoxColumn, eventIdDataGridViewTextBoxColumn, participantIdDataGridViewTextBoxColumn, EventName, ParticipantName });
            dataGridView1.DataSource = eventParticipantsBindingSource;
            dataGridView1.Location = new Point(188, 16);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(663, 392);
            dataGridView1.TabIndex = 0;
            // 
            // kapcsolatIdDataGridViewTextBoxColumn
            // 
            kapcsolatIdDataGridViewTextBoxColumn.DataPropertyName = "KapcsolatId";
            kapcsolatIdDataGridViewTextBoxColumn.HeaderText = "KapcsolatId";
            kapcsolatIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            kapcsolatIdDataGridViewTextBoxColumn.Name = "kapcsolatIdDataGridViewTextBoxColumn";
            kapcsolatIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // eventIdDataGridViewTextBoxColumn
            // 
            eventIdDataGridViewTextBoxColumn.DataPropertyName = "EventId";
            eventIdDataGridViewTextBoxColumn.HeaderText = "EventId";
            eventIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            eventIdDataGridViewTextBoxColumn.Name = "eventIdDataGridViewTextBoxColumn";
            eventIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // participantIdDataGridViewTextBoxColumn
            // 
            participantIdDataGridViewTextBoxColumn.DataPropertyName = "ParticipantId";
            participantIdDataGridViewTextBoxColumn.HeaderText = "ParticipantId";
            participantIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            participantIdDataGridViewTextBoxColumn.Name = "participantIdDataGridViewTextBoxColumn";
            participantIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // EventName
            // 
            EventName.DataPropertyName = "EventId";
            EventName.DataSource = eventsBindingSource;
            EventName.DisplayMember = "Name";
            EventName.HeaderText = "Event Name";
            EventName.MinimumWidth = 6;
            EventName.Name = "EventName";
            EventName.ValueMember = "EventId";
            EventName.Width = 125;
            // 
            // eventsBindingSource
            // 
            eventsBindingSource.DataSource = typeof(Models.Events);
            // 
            // ParticipantName
            // 
            ParticipantName.DataPropertyName = "ParticipantId";
            ParticipantName.DataSource = participantsBindingSource;
            ParticipantName.DisplayMember = "Name";
            ParticipantName.HeaderText = "Participant Name";
            ParticipantName.MinimumWidth = 6;
            ParticipantName.Name = "ParticipantName";
            ParticipantName.ValueMember = "ParticipantId";
            ParticipantName.Width = 125;
            // 
            // participantsBindingSource
            // 
            participantsBindingSource.DataSource = typeof(Models.Participants);
            // 
            // eventParticipantsBindingSource
            // 
            eventParticipantsBindingSource.DataSource = typeof(Models.EventParticipants);
            // 
            // UserControlEAP
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridView1);
            Name = "UserControlEAP";
            Size = new Size(1024, 499);
            Load += UserControlEAP_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)eventsBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)participantsBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)eventParticipantsBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private BindingSource eventParticipantsBindingSource;
        private BindingSource eventsBindingSource;
        private DataGridViewTextBoxColumn kapcsolatIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn eventIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn participantIdDataGridViewTextBoxColumn;
        private DataGridViewComboBoxColumn EventName;
        private DataGridViewComboBoxColumn ParticipantName;
        private BindingSource participantsBindingSource;
    }
}
