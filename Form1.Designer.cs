namespace QuanLySinhVien.GUI;

partial class Form1
{
    private System.ComponentModel.IContainer components = null!;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
        lblTieuDe = new Label();
        dgvSinhVien = new DataGridView();
        lblTrangThai = new Label();
        ((System.ComponentModel.ISupportInitialize)dgvSinhVien).BeginInit();
        SuspendLayout();
        //
        // lblTieuDe
        //
        lblTieuDe.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
        lblTieuDe.Location = new Point(12, 9);
        lblTieuDe.Name = "lblTieuDe";
        lblTieuDe.Size = new Size(616, 32);
        lblTieuDe.TabIndex = 0;
        lblTieuDe.Text = "DANH SÁCH SINH VIÊN - KIẾN TRÚC 3 LỚP";
        lblTieuDe.TextAlign = ContentAlignment.MiddleCenter;
        //
        // dgvSinhVien
        //
        dgvSinhVien.AllowUserToAddRows = false;
        dgvSinhVien.AllowUserToDeleteRows = false;
        dgvSinhVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvSinhVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvSinhVien.Location = new Point(12, 50);
        dgvSinhVien.MultiSelect = false;
        dgvSinhVien.Name = "dgvSinhVien";
        dgvSinhVien.ReadOnly = true;
        dgvSinhVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvSinhVien.Size = new Size(616, 280);
        dgvSinhVien.TabIndex = 1;
        //
        // lblTrangThai
        //
        lblTrangThai.Location = new Point(12, 340);
        lblTrangThai.Name = "lblTrangThai";
        lblTrangThai.Size = new Size(616, 23);
        lblTrangThai.TabIndex = 2;
        lblTrangThai.Text = "Sẵn sàng.";
        //
        // Form1
        //
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(640, 375);
        Controls.Add(lblTieuDe);
        Controls.Add(dgvSinhVien);
        Controls.Add(lblTrangThai);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Name = "Form1";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Quản lý sinh viên - 3 lớp";
        Load += Form1_Load;
        ((System.ComponentModel.ISupportInitialize)dgvSinhVien).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private Label lblTieuDe;
    private DataGridView dgvSinhVien;
    private Label lblTrangThai;
}
