namespace WinFormsAppZH3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            rendezvenyIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            vasarloIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Vasarlo = new DataGridViewComboBoxColumn();
            vasarlobindingSource = new BindingSource(components);
            Rendezveny = new DataGridViewComboBoxColumn();
            rendezvenybindingSource = new BindingSource(components);
            vasarlasIdopontDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            arDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            rendezvenyDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            vasarloDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            jegyBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)vasarlobindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rendezvenybindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)jegyBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { rendezvenyIdDataGridViewTextBoxColumn, vasarloIdDataGridViewTextBoxColumn, Vasarlo, Rendezveny, vasarlasIdopontDataGridViewTextBoxColumn, arDataGridViewTextBoxColumn, rendezvenyDataGridViewTextBoxColumn, vasarloDataGridViewTextBoxColumn });
            dataGridView1.DataSource = jegyBindingSource;
            dataGridView1.Location = new Point(15, 13);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(546, 424);
            dataGridView1.TabIndex = 0;
            // 
            // rendezvenyIdDataGridViewTextBoxColumn
            // 
            rendezvenyIdDataGridViewTextBoxColumn.DataPropertyName = "RendezvenyId";
            rendezvenyIdDataGridViewTextBoxColumn.HeaderText = "RendezvenyId";
            rendezvenyIdDataGridViewTextBoxColumn.Name = "rendezvenyIdDataGridViewTextBoxColumn";
            rendezvenyIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // vasarloIdDataGridViewTextBoxColumn
            // 
            vasarloIdDataGridViewTextBoxColumn.DataPropertyName = "VasarloId";
            vasarloIdDataGridViewTextBoxColumn.HeaderText = "VasarloId";
            vasarloIdDataGridViewTextBoxColumn.Name = "vasarloIdDataGridViewTextBoxColumn";
            vasarloIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // Vasarlo
            // 
            Vasarlo.DataPropertyName = "VasarloId";
            Vasarlo.DataSource = vasarlobindingSource;
            Vasarlo.DisplayMember = "Nev";
            Vasarlo.HeaderText = "Vasarlo";
            Vasarlo.Name = "Vasarlo";
            Vasarlo.ValueMember = "VasarloId";
            // 
            // vasarlobindingSource
            // 
            vasarlobindingSource.DataSource = typeof(EventModels.Vasarlo);
            // 
            // Rendezveny
            // 
            Rendezveny.DataPropertyName = "RendezvenyId";
            Rendezveny.DataSource = rendezvenybindingSource;
            Rendezveny.DisplayMember = "Nev";
            Rendezveny.HeaderText = "Rendezveny";
            Rendezveny.Name = "Rendezveny";
            Rendezveny.ValueMember = "RendezvenyId";
            // 
            // rendezvenybindingSource
            // 
            rendezvenybindingSource.DataSource = typeof(EventModels.Rendezveny);
            // 
            // vasarlasIdopontDataGridViewTextBoxColumn
            // 
            vasarlasIdopontDataGridViewTextBoxColumn.DataPropertyName = "VasarlasIdopont";
            vasarlasIdopontDataGridViewTextBoxColumn.HeaderText = "VasarlasIdopont";
            vasarlasIdopontDataGridViewTextBoxColumn.Name = "vasarlasIdopontDataGridViewTextBoxColumn";
            // 
            // arDataGridViewTextBoxColumn
            // 
            arDataGridViewTextBoxColumn.DataPropertyName = "Ar";
            arDataGridViewTextBoxColumn.HeaderText = "Ar";
            arDataGridViewTextBoxColumn.Name = "arDataGridViewTextBoxColumn";
            // 
            // rendezvenyDataGridViewTextBoxColumn
            // 
            rendezvenyDataGridViewTextBoxColumn.DataPropertyName = "Rendezveny";
            rendezvenyDataGridViewTextBoxColumn.HeaderText = "Rendezveny";
            rendezvenyDataGridViewTextBoxColumn.Name = "rendezvenyDataGridViewTextBoxColumn";
            rendezvenyDataGridViewTextBoxColumn.Visible = false;
            // 
            // vasarloDataGridViewTextBoxColumn
            // 
            vasarloDataGridViewTextBoxColumn.DataPropertyName = "Vasarlo";
            vasarloDataGridViewTextBoxColumn.HeaderText = "Vasarlo";
            vasarloDataGridViewTextBoxColumn.Name = "vasarloDataGridViewTextBoxColumn";
            vasarloDataGridViewTextBoxColumn.Visible = false;
            // 
            // jegyBindingSource
            // 
            jegyBindingSource.DataSource = typeof(EventModels.Jegy);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)vasarlobindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)rendezvenybindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)jegyBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private BindingSource jegyBindingSource;
        private BindingSource rendezvenybindingSource;
        private BindingSource vasarlobindingSource;
        private DataGridViewTextBoxColumn rendezvenyIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn vasarloIdDataGridViewTextBoxColumn;
        private DataGridViewComboBoxColumn Vasarlo;
        private DataGridViewComboBoxColumn Rendezveny;
        private DataGridViewTextBoxColumn vasarlasIdopontDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn arDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn rendezvenyDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn vasarloDataGridViewTextBoxColumn;
    }
}
