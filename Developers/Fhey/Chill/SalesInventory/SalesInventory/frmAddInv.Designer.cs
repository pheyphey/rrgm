namespace SalesInventory
{
    partial class frmAddInv
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
            this.txtItemID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtType = new System.Windows.Forms.TextBox();
            this.txtLastCost = new System.Windows.Forms.TextBox();
            this.txtPrc = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtLoc = new System.Windows.Forms.TextBox();
            this.txtQtyHnd = new System.Windows.Forms.TextBox();
            this.txtQtySO = new System.Windows.Forms.TextBox();
            this.txtQtyPO = new System.Windows.Forms.TextBox();
            this.txtSupID = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCricLvl = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtReordrLvL = new System.Windows.Forms.TextBox();
            this.txtSafeLvl = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtItemID
            // 
            this.txtItemID.Location = new System.Drawing.Point(108, 39);
            this.txtItemID.Name = "txtItemID";
            this.txtItemID.Size = new System.Drawing.Size(162, 20);
            this.txtItemID.TabIndex = 54;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 53;
            this.label1.Text = "Item ID";
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(108, 146);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(162, 20);
            this.txtType.TabIndex = 51;
            // 
            // txtLastCost
            // 
            this.txtLastCost.Location = new System.Drawing.Point(109, 120);
            this.txtLastCost.Name = "txtLastCost";
            this.txtLastCost.Size = new System.Drawing.Size(162, 20);
            this.txtLastCost.TabIndex = 49;
            // 
            // txtPrc
            // 
            this.txtPrc.Location = new System.Drawing.Point(109, 94);
            this.txtPrc.Name = "txtPrc";
            this.txtPrc.Size = new System.Drawing.Size(162, 20);
            this.txtPrc.TabIndex = 48;
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(109, 68);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(162, 20);
            this.txtDesc.TabIndex = 47;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(63, 97);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 46;
            this.label10.Text = "Price";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 123);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 13);
            this.label9.TabIndex = 45;
            this.label9.Text = "Last Unit Cost";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(34, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 44;
            this.label8.Text = "Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 55;
            this.label2.Text = "Item Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 57;
            this.label4.Text = "Location";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(303, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 58;
            this.label5.Text = "Preffered Vendor ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(341, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 59;
            this.label6.Text = "Qty on PO\'s";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(341, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 60;
            this.label7.Text = "Qty on SO\'s";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(337, 123);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 13);
            this.label12.TabIndex = 61;
            this.label12.Text = "Qty on Hand";
            // 
            // txtLoc
            // 
            this.txtLoc.Location = new System.Drawing.Point(109, 172);
            this.txtLoc.Name = "txtLoc";
            this.txtLoc.Size = new System.Drawing.Size(162, 20);
            this.txtLoc.TabIndex = 63;
            // 
            // txtQtyHnd
            // 
            this.txtQtyHnd.Location = new System.Drawing.Point(410, 120);
            this.txtQtyHnd.Name = "txtQtyHnd";
            this.txtQtyHnd.Size = new System.Drawing.Size(162, 20);
            this.txtQtyHnd.TabIndex = 64;
            // 
            // txtQtySO
            // 
            this.txtQtySO.Location = new System.Drawing.Point(410, 149);
            this.txtQtySO.Name = "txtQtySO";
            this.txtQtySO.Size = new System.Drawing.Size(162, 20);
            this.txtQtySO.TabIndex = 65;
            // 
            // txtQtyPO
            // 
            this.txtQtyPO.Location = new System.Drawing.Point(410, 175);
            this.txtQtyPO.Name = "txtQtyPO";
            this.txtQtyPO.Size = new System.Drawing.Size(162, 20);
            this.txtQtyPO.TabIndex = 66;
            // 
            // txtSupID
            // 
            this.txtSupID.Location = new System.Drawing.Point(410, 201);
            this.txtSupID.Name = "txtSupID";
            this.txtSupID.Size = new System.Drawing.Size(162, 20);
            this.txtSupID.TabIndex = 67;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 13);
            this.label13.TabIndex = 68;
            this.label13.Text = "ADD ITEMS";
            // 
            // txtCricLvl
            // 
            this.txtCricLvl.Location = new System.Drawing.Point(410, 68);
            this.txtCricLvl.Name = "txtCricLvl";
            this.txtCricLvl.Size = new System.Drawing.Size(162, 20);
            this.txtCricLvl.TabIndex = 70;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(337, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 69;
            this.label3.Text = "Critical Level";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(372, 252);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 71;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(484, 251);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 72;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // txtReordrLvL
            // 
            this.txtReordrLvL.Location = new System.Drawing.Point(410, 94);
            this.txtReordrLvL.Name = "txtReordrLvL";
            this.txtReordrLvL.Size = new System.Drawing.Size(162, 20);
            this.txtReordrLvL.TabIndex = 73;
            // 
            // txtSafeLvl
            // 
            this.txtSafeLvl.Location = new System.Drawing.Point(410, 42);
            this.txtSafeLvl.Name = "txtSafeLvl";
            this.txtSafeLvl.Size = new System.Drawing.Size(162, 20);
            this.txtSafeLvl.TabIndex = 74;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(330, 97);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 13);
            this.label11.TabIndex = 75;
            this.label11.Text = "Reorder Level";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(337, 45);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 13);
            this.label14.TabIndex = 76;
            this.label14.Text = "Safe Level";
            // 
            // frmAddInv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 301);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtSafeLvl);
            this.Controls.Add(this.txtReordrLvL);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtCricLvl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtSupID);
            this.Controls.Add(this.txtQtyPO);
            this.Controls.Add(this.txtQtySO);
            this.Controls.Add(this.txtQtyHnd);
            this.Controls.Add(this.txtLoc);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtItemID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.txtLastCost);
            this.Controls.Add(this.txtPrc);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Name = "frmAddInv";
            this.Text = "frmAddInv";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtItemID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.TextBox txtLastCost;
        private System.Windows.Forms.TextBox txtPrc;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtLoc;
        private System.Windows.Forms.TextBox txtQtyHnd;
        private System.Windows.Forms.TextBox txtQtySO;
        private System.Windows.Forms.TextBox txtQtyPO;
        private System.Windows.Forms.TextBox txtSupID;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtCricLvl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtReordrLvL;
        private System.Windows.Forms.TextBox txtSafeLvl;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
    }
}