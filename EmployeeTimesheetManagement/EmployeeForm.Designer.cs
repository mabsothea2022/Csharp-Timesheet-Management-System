namespace EmployeeTimesheetManagement;

partial class EmployeeForm
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

    protected override void OnFormClosing(FormClosingEventArgs e)
    {
        EmployeeForm_Closing(e);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        label1 = new Label();
        label2 = new Label();
        label3 = new Label();
        label4 = new Label();
        label5 = new Label();
        identityTextBox = new TextBox();
        fullnameTextBox = new TextBox();
        positionTextBox = new TextBox();
        cardnoTextBox = new TextBox();
        addnewButton = new Button();
        saveButton = new Button();
        updateButton = new Button();
        dataGridView1 = new DataGridView();
        DeleteButton = new Button();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
        label1.Location = new Point(482, 27);
        label1.Name = "label1";
        label1.Size = new Size(526, 89);
        label1.TabIndex = 0;
        label1.Text = "Employee Form";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(29, 123);
        label2.Name = "label2";
        label2.Size = new Size(248, 65);
        label2.TabIndex = 1;
        label2.Text = "Identity ID";
        label2.TextAlign = ContentAlignment.TopRight;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(31, 227);
        label3.Name = "label3";
        label3.Size = new Size(241, 65);
        label3.TabIndex = 2;
        label3.Text = "Full Name";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(56, 329);
        label4.Name = "label4";
        label4.Size = new Size(196, 65);
        label4.TabIndex = 3;
        label4.Text = "Position";
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(53, 444);
        label5.Name = "label5";
        label5.Size = new Size(204, 65);
        label5.TabIndex = 4;
        label5.Text = "Card No";
        // 
        // identityTextBox
        // 
        identityTextBox.Location = new Point(355, 123);
        identityTextBox.Name = "identityTextBox";
        identityTextBox.ReadOnly = true;
        identityTextBox.Size = new Size(568, 71);
        identityTextBox.TabIndex = 5;
        // 
        // fullnameTextBox
        // 
        fullnameTextBox.Location = new Point(355, 227);
        fullnameTextBox.Name = "fullnameTextBox";
        fullnameTextBox.Size = new Size(568, 71);
        fullnameTextBox.TabIndex = 6;
        // 
        // positionTextBox
        // 
        positionTextBox.Location = new Point(355, 329);
        positionTextBox.Name = "positionTextBox";
        positionTextBox.Size = new Size(568, 71);
        positionTextBox.TabIndex = 7;
        // 
        // cardnoTextBox
        // 
        cardnoTextBox.Location = new Point(355, 444);
        cardnoTextBox.Name = "cardnoTextBox";
        cardnoTextBox.Size = new Size(568, 71);
        cardnoTextBox.TabIndex = 8;
        // 
        // addnewButton
        // 
        addnewButton.Location = new Point(58, 685);
        addnewButton.Name = "addnewButton";
        addnewButton.Size = new Size(134, 87);
        addnewButton.TabIndex = 9;
        addnewButton.Text = "Add New";
        addnewButton.UseVisualStyleBackColor = true;
        addnewButton.Click += addnewButton_Click;
        // 
        // saveButton
        // 
        saveButton.Location = new Point(221, 685);
        saveButton.Name = "saveButton";
        saveButton.Size = new Size(134, 87);
        saveButton.TabIndex = 10;
        saveButton.Text = "Save";
        saveButton.UseVisualStyleBackColor = true;
        saveButton.Click += saveButton_Click;
        // 
        // updateButton
        // 
        updateButton.Location = new Point(375, 685);
        updateButton.Name = "updateButton";
        updateButton.Size = new Size(196, 87);
        updateButton.TabIndex = 11;
        updateButton.Text = "Update";
        updateButton.UseVisualStyleBackColor = true;
        updateButton.Click += updateButton_Click;
        // 
        // dataGridView1
        // 
        dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridView1.Location = new Point(946, 123);
        dataGridView1.Name = "dataGridView1";
        dataGridView1.RowHeadersWidth = 51;
        dataGridView1.RowTemplate.Height = 32;
        dataGridView1.Size = new Size(1060, 786);
        dataGridView1.TabIndex = 12;
        dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
        // 
        // DeleteButton
        // 
        DeleteButton.Location = new Point(600, 685);
        DeleteButton.Name = "DeleteButton";
        DeleteButton.Size = new Size(251, 87);
        DeleteButton.TabIndex = 13;
        DeleteButton.Text = "Delete";
        DeleteButton.UseVisualStyleBackColor = true;
        DeleteButton.Click += DeleteButton_Click;
        // 
        // EmployeeForm
        // 
        AutoScaleDimensions = new SizeF(240F, 240F);
        AutoScaleMode = AutoScaleMode.Dpi;
        ClientSize = new Size(2018, 950);
        Controls.Add(DeleteButton);
        Controls.Add(dataGridView1);
        Controls.Add(updateButton);
        Controls.Add(saveButton);
        Controls.Add(addnewButton);
        Controls.Add(cardnoTextBox);
        Controls.Add(positionTextBox);
        Controls.Add(fullnameTextBox);
        Controls.Add(identityTextBox);
        Controls.Add(label5);
        Controls.Add(label4);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(label1);
        Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
        Margin = new Padding(4);
        Name = "EmployeeForm";
        Text = "EmployeeForm";
        ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label1;=
    private Label label2;
    private Label label3;
    private Label label4;
    private Label label5;
    private TextBox identityTextBox;
    private TextBox fullnameTextBox;
    private TextBox positionTextBox;
    private TextBox cardnoTextBox;
    private Button addnewButton;
    private Button saveButton;
    private Button updateButton;
    private DataGridView dataGridView1;
    private Button DeleteButton;
}