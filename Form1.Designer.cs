namespace CalculatorFull
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tbInput = new System.Windows.Forms.TextBox();
            this.btnClr = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnNum7 = new System.Windows.Forms.Button();
            this.btnNum8 = new System.Windows.Forms.Button();
            this.btnNum9 = new System.Windows.Forms.Button();
            this.btnMul = new System.Windows.Forms.Button();
            this.btnNum4 = new System.Windows.Forms.Button();
            this.btnNum5 = new System.Windows.Forms.Button();
            this.btnNum6 = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnNum1 = new System.Windows.Forms.Button();
            this.btnNum2 = new System.Windows.Forms.Button();
            this.btnNum3 = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnOppo = new System.Windows.Forms.Button();
            this.btnNum0 = new System.Windows.Forms.Button();
            this.btnDot = new System.Windows.Forms.Button();
            this.btnRes = new System.Windows.Forms.Button();
            this.btnExp = new System.Windows.Forms.Button();
            this.btnSqr = new System.Windows.Forms.Button();
            this.btnSqrt = new System.Windows.Forms.Button();
            this.btnOFF = new System.Windows.Forms.Button();
            this.tbTemp = new System.Windows.Forms.TextBox();
            this.tbRes = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbInput
            // 
            this.tbInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbInput.BackColor = System.Drawing.Color.PowderBlue;
            this.tbInput.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbInput.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tbInput.Location = new System.Drawing.Point(12, 95);
            this.tbInput.MaxLength = 21;
            this.tbInput.Multiline = true;
            this.tbInput.Name = "tbInput";
            this.tbInput.ReadOnly = true;
            this.tbInput.Size = new System.Drawing.Size(350, 60);
            this.tbInput.TabIndex = 0;
            this.tbInput.Text = "0";
            this.tbInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnClr
            // 
            this.btnClr.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClr.BackColor = System.Drawing.Color.Linen;
            this.btnClr.FlatAppearance.BorderSize = 0;
            this.btnClr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClr.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClr.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnClr.Location = new System.Drawing.Point(101, 176);
            this.btnClr.Name = "btnClr";
            this.btnClr.Size = new System.Drawing.Size(83, 46);
            this.btnClr.TabIndex = 2;
            this.btnClr.Text = "C";
            this.btnClr.UseVisualStyleBackColor = false;
            this.btnClr.Click += new System.EventHandler(this.btnController_Click);
            // 
            // btnDel
            // 
            this.btnDel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDel.BackColor = System.Drawing.Color.Linen;
            this.btnDel.FlatAppearance.BorderSize = 0;
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDel.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnDel.Location = new System.Drawing.Point(190, 176);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(172, 46);
            this.btnDel.TabIndex = 3;
            this.btnDel.Text = "Backspace";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnController_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDiv.BackColor = System.Drawing.Color.Linen;
            this.btnDiv.FlatAppearance.BorderSize = 0;
            this.btnDiv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiv.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiv.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnDiv.Location = new System.Drawing.Point(279, 228);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(83, 46);
            this.btnDiv.TabIndex = 7;
            this.btnDiv.Text = "÷";
            this.btnDiv.UseVisualStyleBackColor = false;
            this.btnDiv.Click += new System.EventHandler(this.btnOperator_Click);
            // 
            // btnNum7
            // 
            this.btnNum7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNum7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnNum7.FlatAppearance.BorderSize = 0;
            this.btnNum7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNum7.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNum7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnNum7.Location = new System.Drawing.Point(12, 280);
            this.btnNum7.Name = "btnNum7";
            this.btnNum7.Size = new System.Drawing.Size(83, 46);
            this.btnNum7.TabIndex = 8;
            this.btnNum7.Text = "7";
            this.btnNum7.UseVisualStyleBackColor = false;
            this.btnNum7.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btnNum8
            // 
            this.btnNum8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNum8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnNum8.FlatAppearance.BorderSize = 0;
            this.btnNum8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNum8.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNum8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnNum8.Location = new System.Drawing.Point(101, 280);
            this.btnNum8.Name = "btnNum8";
            this.btnNum8.Size = new System.Drawing.Size(83, 46);
            this.btnNum8.TabIndex = 9;
            this.btnNum8.Text = "8";
            this.btnNum8.UseVisualStyleBackColor = false;
            this.btnNum8.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btnNum9
            // 
            this.btnNum9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNum9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnNum9.FlatAppearance.BorderSize = 0;
            this.btnNum9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNum9.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNum9.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnNum9.Location = new System.Drawing.Point(190, 280);
            this.btnNum9.Name = "btnNum9";
            this.btnNum9.Size = new System.Drawing.Size(83, 46);
            this.btnNum9.TabIndex = 10;
            this.btnNum9.Text = "9";
            this.btnNum9.UseVisualStyleBackColor = false;
            this.btnNum9.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btnMul
            // 
            this.btnMul.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMul.BackColor = System.Drawing.Color.Linen;
            this.btnMul.FlatAppearance.BorderSize = 0;
            this.btnMul.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMul.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMul.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnMul.Location = new System.Drawing.Point(279, 280);
            this.btnMul.Name = "btnMul";
            this.btnMul.Size = new System.Drawing.Size(83, 46);
            this.btnMul.TabIndex = 11;
            this.btnMul.Text = "×";
            this.btnMul.UseVisualStyleBackColor = false;
            this.btnMul.Click += new System.EventHandler(this.btnOperator_Click);
            // 
            // btnNum4
            // 
            this.btnNum4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNum4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnNum4.FlatAppearance.BorderSize = 0;
            this.btnNum4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNum4.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNum4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnNum4.Location = new System.Drawing.Point(12, 332);
            this.btnNum4.Name = "btnNum4";
            this.btnNum4.Size = new System.Drawing.Size(83, 46);
            this.btnNum4.TabIndex = 12;
            this.btnNum4.Text = "4";
            this.btnNum4.UseVisualStyleBackColor = false;
            this.btnNum4.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btnNum5
            // 
            this.btnNum5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNum5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnNum5.FlatAppearance.BorderSize = 0;
            this.btnNum5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNum5.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNum5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnNum5.Location = new System.Drawing.Point(101, 332);
            this.btnNum5.Name = "btnNum5";
            this.btnNum5.Size = new System.Drawing.Size(83, 46);
            this.btnNum5.TabIndex = 13;
            this.btnNum5.Text = "5";
            this.btnNum5.UseVisualStyleBackColor = false;
            this.btnNum5.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btnNum6
            // 
            this.btnNum6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNum6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnNum6.FlatAppearance.BorderSize = 0;
            this.btnNum6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNum6.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNum6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnNum6.Location = new System.Drawing.Point(190, 332);
            this.btnNum6.Name = "btnNum6";
            this.btnNum6.Size = new System.Drawing.Size(83, 46);
            this.btnNum6.TabIndex = 14;
            this.btnNum6.Text = "6";
            this.btnNum6.UseVisualStyleBackColor = false;
            this.btnNum6.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btnSub
            // 
            this.btnSub.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSub.BackColor = System.Drawing.Color.Linen;
            this.btnSub.FlatAppearance.BorderSize = 0;
            this.btnSub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSub.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSub.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSub.Location = new System.Drawing.Point(279, 332);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(83, 46);
            this.btnSub.TabIndex = 15;
            this.btnSub.Text = "-";
            this.btnSub.UseVisualStyleBackColor = false;
            this.btnSub.Click += new System.EventHandler(this.btnOperator_Click);
            // 
            // btnNum1
            // 
            this.btnNum1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNum1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnNum1.FlatAppearance.BorderSize = 0;
            this.btnNum1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNum1.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNum1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnNum1.Location = new System.Drawing.Point(12, 384);
            this.btnNum1.Name = "btnNum1";
            this.btnNum1.Size = new System.Drawing.Size(83, 46);
            this.btnNum1.TabIndex = 16;
            this.btnNum1.Text = "1";
            this.btnNum1.UseVisualStyleBackColor = false;
            this.btnNum1.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btnNum2
            // 
            this.btnNum2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNum2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnNum2.FlatAppearance.BorderSize = 0;
            this.btnNum2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNum2.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNum2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnNum2.Location = new System.Drawing.Point(101, 384);
            this.btnNum2.Name = "btnNum2";
            this.btnNum2.Size = new System.Drawing.Size(83, 46);
            this.btnNum2.TabIndex = 17;
            this.btnNum2.Text = "2";
            this.btnNum2.UseVisualStyleBackColor = false;
            this.btnNum2.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btnNum3
            // 
            this.btnNum3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNum3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnNum3.FlatAppearance.BorderSize = 0;
            this.btnNum3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNum3.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNum3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnNum3.Location = new System.Drawing.Point(190, 384);
            this.btnNum3.Name = "btnNum3";
            this.btnNum3.Size = new System.Drawing.Size(83, 46);
            this.btnNum3.TabIndex = 18;
            this.btnNum3.Text = "3";
            this.btnNum3.UseVisualStyleBackColor = false;
            this.btnNum3.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.BackColor = System.Drawing.Color.Linen;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnAdd.Location = new System.Drawing.Point(279, 384);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(83, 46);
            this.btnAdd.TabIndex = 19;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnOperator_Click);
            // 
            // btnOppo
            // 
            this.btnOppo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOppo.BackColor = System.Drawing.Color.Linen;
            this.btnOppo.FlatAppearance.BorderSize = 0;
            this.btnOppo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOppo.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOppo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnOppo.Location = new System.Drawing.Point(12, 436);
            this.btnOppo.Name = "btnOppo";
            this.btnOppo.Size = new System.Drawing.Size(83, 46);
            this.btnOppo.TabIndex = 20;
            this.btnOppo.Text = "+/-";
            this.btnOppo.UseVisualStyleBackColor = false;
            this.btnOppo.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btnNum0
            // 
            this.btnNum0.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNum0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnNum0.FlatAppearance.BorderSize = 0;
            this.btnNum0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNum0.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNum0.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnNum0.Location = new System.Drawing.Point(101, 436);
            this.btnNum0.Name = "btnNum0";
            this.btnNum0.Size = new System.Drawing.Size(83, 46);
            this.btnNum0.TabIndex = 21;
            this.btnNum0.Text = "0";
            this.btnNum0.UseVisualStyleBackColor = false;
            this.btnNum0.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btnDot
            // 
            this.btnDot.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDot.BackColor = System.Drawing.Color.Linen;
            this.btnDot.FlatAppearance.BorderSize = 0;
            this.btnDot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDot.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDot.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnDot.Location = new System.Drawing.Point(190, 436);
            this.btnDot.Name = "btnDot";
            this.btnDot.Size = new System.Drawing.Size(83, 46);
            this.btnDot.TabIndex = 22;
            this.btnDot.Text = ".";
            this.btnDot.UseVisualStyleBackColor = false;
            this.btnDot.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btnRes
            // 
            this.btnRes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRes.BackColor = System.Drawing.Color.Linen;
            this.btnRes.FlatAppearance.BorderSize = 0;
            this.btnRes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRes.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRes.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnRes.Location = new System.Drawing.Point(279, 436);
            this.btnRes.Name = "btnRes";
            this.btnRes.Size = new System.Drawing.Size(83, 46);
            this.btnRes.TabIndex = 23;
            this.btnRes.Text = "=";
            this.btnRes.UseVisualStyleBackColor = false;
            this.btnRes.Click += new System.EventHandler(this.btnController_Click);
            // 
            // btnExp
            // 
            this.btnExp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExp.BackColor = System.Drawing.Color.Linen;
            this.btnExp.FlatAppearance.BorderSize = 0;
            this.btnExp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExp.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExp.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnExp.Location = new System.Drawing.Point(12, 228);
            this.btnExp.Name = "btnExp";
            this.btnExp.Size = new System.Drawing.Size(83, 46);
            this.btnExp.TabIndex = 4;
            this.btnExp.Text = "Exp";
            this.btnExp.UseVisualStyleBackColor = false;
            this.btnExp.Click += new System.EventHandler(this.btnAdv_Click);
            // 
            // btnSqr
            // 
            this.btnSqr.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSqr.BackColor = System.Drawing.Color.Linen;
            this.btnSqr.FlatAppearance.BorderSize = 0;
            this.btnSqr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSqr.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSqr.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSqr.Location = new System.Drawing.Point(101, 228);
            this.btnSqr.Name = "btnSqr";
            this.btnSqr.Size = new System.Drawing.Size(83, 46);
            this.btnSqr.TabIndex = 5;
            this.btnSqr.Text = "Sqr";
            this.btnSqr.UseVisualStyleBackColor = false;
            this.btnSqr.Click += new System.EventHandler(this.btnAdv_Click);
            // 
            // btnSqrt
            // 
            this.btnSqrt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSqrt.BackColor = System.Drawing.Color.Linen;
            this.btnSqrt.FlatAppearance.BorderSize = 0;
            this.btnSqrt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSqrt.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSqrt.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSqrt.Location = new System.Drawing.Point(190, 228);
            this.btnSqrt.Name = "btnSqrt";
            this.btnSqrt.Size = new System.Drawing.Size(83, 46);
            this.btnSqrt.TabIndex = 6;
            this.btnSqrt.Text = "Sqrt";
            this.btnSqrt.UseVisualStyleBackColor = false;
            this.btnSqrt.Click += new System.EventHandler(this.btnAdv_Click);
            // 
            // btnOFF
            // 
            this.btnOFF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOFF.BackColor = System.Drawing.Color.Linen;
            this.btnOFF.FlatAppearance.BorderSize = 0;
            this.btnOFF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOFF.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOFF.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnOFF.Location = new System.Drawing.Point(12, 176);
            this.btnOFF.Name = "btnOFF";
            this.btnOFF.Size = new System.Drawing.Size(83, 46);
            this.btnOFF.TabIndex = 1;
            this.btnOFF.Text = "OFF";
            this.btnOFF.UseVisualStyleBackColor = false;
            this.btnOFF.Click += new System.EventHandler(this.btnController_Click);
            // 
            // tbTemp
            // 
            this.tbTemp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbTemp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tbTemp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTemp.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTemp.Location = new System.Drawing.Point(12, 47);
            this.tbTemp.Name = "tbTemp";
            this.tbTemp.ReadOnly = true;
            this.tbTemp.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tbTemp.Size = new System.Drawing.Size(350, 17);
            this.tbTemp.TabIndex = 24;
            this.tbTemp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbRes
            // 
            this.tbRes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbRes.BackColor = System.Drawing.Color.PowderBlue;
            this.tbRes.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRes.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tbRes.Location = new System.Drawing.Point(12, 95);
            this.tbRes.MaxLength = 21;
            this.tbRes.Multiline = true;
            this.tbRes.Name = "tbRes";
            this.tbRes.ReadOnly = true;
            this.tbRes.Size = new System.Drawing.Size(350, 60);
            this.tbRes.TabIndex = 25;
            this.tbRes.Text = "0";
            this.tbRes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbRes.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(374, 497);
            this.Controls.Add(this.tbRes);
            this.Controls.Add(this.tbTemp);
            this.Controls.Add(this.btnRes);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDot);
            this.Controls.Add(this.btnNum3);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.btnNum6);
            this.Controls.Add(this.btnMul);
            this.Controls.Add(this.btnNum0);
            this.Controls.Add(this.btnNum2);
            this.Controls.Add(this.btnNum9);
            this.Controls.Add(this.btnNum5);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnOppo);
            this.Controls.Add(this.btnNum1);
            this.Controls.Add(this.btnNum8);
            this.Controls.Add(this.btnNum4);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnNum7);
            this.Controls.Add(this.btnClr);
            this.Controls.Add(this.btnOFF);
            this.Controls.Add(this.btnSqrt);
            this.Controls.Add(this.btnSqr);
            this.Controls.Add(this.btnExp);
            this.Controls.Add(this.tbInput);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(390, 536);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator By DvL";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.Form1_HelpButtonClicked);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.Button btnClr;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btnNum7;
        private System.Windows.Forms.Button btnNum8;
        private System.Windows.Forms.Button btnNum9;
        private System.Windows.Forms.Button btnMul;
        private System.Windows.Forms.Button btnNum4;
        private System.Windows.Forms.Button btnNum5;
        private System.Windows.Forms.Button btnNum6;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnNum1;
        private System.Windows.Forms.Button btnNum2;
        private System.Windows.Forms.Button btnNum3;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnOppo;
        private System.Windows.Forms.Button btnNum0;
        private System.Windows.Forms.Button btnDot;
        private System.Windows.Forms.Button btnRes;
        private System.Windows.Forms.Button btnExp;
        private System.Windows.Forms.Button btnSqr;
        private System.Windows.Forms.Button btnSqrt;
        private System.Windows.Forms.Button btnOFF;
        private System.Windows.Forms.TextBox tbTemp;
        private System.Windows.Forms.TextBox tbRes;
    }
}

