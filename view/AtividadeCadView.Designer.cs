﻿namespace Projeto_LP2_2018_1.view
{
    partial class AtividadeCadView
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbAtividades = new System.Windows.Forms.Label();
            this.lbNome = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CBoxVoluntarios = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CBoxSalas = new System.Windows.Forms.ComboBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dataGridAlunosCad = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.txtData = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SisPS = new System.Windows.Forms.Label();
            this.lbId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAtivo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAlunosCad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Location = new System.Drawing.Point(14, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(971, 10);
            this.panel2.TabIndex = 29;
            // 
            // lbAtividades
            // 
            this.lbAtividades.AutoSize = true;
            this.lbAtividades.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAtividades.Location = new System.Drawing.Point(9, 12);
            this.lbAtividades.Name = "lbAtividades";
            this.lbAtividades.Size = new System.Drawing.Size(120, 25);
            this.lbAtividades.TabIndex = 28;
            this.lbAtividades.Text = "Atividades";
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNome.Location = new System.Drawing.Point(10, 105);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(57, 21);
            this.lbNome.TabIndex = 30;
            this.lbNome.Text = "Nome";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(145, 101);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(351, 31);
            this.txtName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 21);
            this.label1.TabIndex = 32;
            this.label1.Text = "Voluntário";
            // 
            // CBoxVoluntarios
            // 
            this.CBoxVoluntarios.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBoxVoluntarios.FormattingEnabled = true;
            this.CBoxVoluntarios.Location = new System.Drawing.Point(145, 142);
            this.CBoxVoluntarios.Name = "CBoxVoluntarios";
            this.CBoxVoluntarios.Size = new System.Drawing.Size(351, 29);
            this.CBoxVoluntarios.TabIndex = 3;
            this.CBoxVoluntarios.Text = "Selecione um voluntário...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(525, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 21);
            this.label2.TabIndex = 34;
            this.label2.Text = "Sala";
            // 
            // CBoxSalas
            // 
            this.CBoxSalas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBoxSalas.FormattingEnabled = true;
            this.CBoxSalas.Location = new System.Drawing.Point(585, 142);
            this.CBoxSalas.Name = "CBoxSalas";
            this.CBoxSalas.Size = new System.Drawing.Size(400, 29);
            this.CBoxSalas.TabIndex = 4;
            this.CBoxSalas.Text = "Selecione uma sala...";
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.Green;
            this.btnOk.FlatAppearance.BorderSize = 0;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOk.Location = new System.Drawing.Point(346, 554);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(150, 30);
            this.btnOk.TabIndex = 7;
            this.btnOk.Text = "Inserir";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Red;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancelar.Location = new System.Drawing.Point(505, 554);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(150, 30);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dataGridAlunosCad
            // 
            this.dataGridAlunosCad.AllowUserToAddRows = false;
            this.dataGridAlunosCad.AllowUserToResizeColumns = false;
            this.dataGridAlunosCad.AllowUserToResizeRows = false;
            this.dataGridAlunosCad.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridAlunosCad.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridAlunosCad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAlunosCad.Location = new System.Drawing.Point(16, 212);
            this.dataGridAlunosCad.Name = "dataGridAlunosCad";
            this.dataGridAlunosCad.ReadOnly = true;
            this.dataGridAlunosCad.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridAlunosCad.Size = new System.Drawing.Size(480, 300);
            this.dataGridAlunosCad.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 21);
            this.label3.TabIndex = 40;
            this.label3.Text = "Alunos cadastrados";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(505, 212);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(480, 300);
            this.dataGridView2.TabIndex = 6;
            // 
            // txtData
            // 
            this.txtData.CustomFormat = "dd/MM/yyyy";
            this.txtData.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtData.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtData.Location = new System.Drawing.Point(585, 101);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(144, 27);
            this.txtData.TabIndex = 2;
            this.txtData.Value = new System.DateTime(2018, 6, 9, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(525, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 21);
            this.label4.TabIndex = 43;
            this.label4.Text = "Data";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(501, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 21);
            this.label5.TabIndex = 44;
            this.label5.Text = "Alunos matriculados";
            // 
            // SisPS
            // 
            this.SisPS.AutoSize = true;
            this.SisPS.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SisPS.ForeColor = System.Drawing.Color.Gray;
            this.SisPS.Location = new System.Drawing.Point(941, 18);
            this.SisPS.Name = "SisPS";
            this.SisPS.Size = new System.Drawing.Size(44, 19);
            this.SisPS.TabIndex = 45;
            this.SisPS.Text = "SisPS";
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbId.Location = new System.Drawing.Point(9, 68);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(26, 21);
            this.lbId.TabIndex = 46;
            this.lbId.Text = "Id";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(145, 62);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(86, 31);
            this.txtId.TabIndex = 47;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(756, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 21);
            this.label6.TabIndex = 48;
            this.label6.Text = "Ativa";
            // 
            // txtAtivo
            // 
            this.txtAtivo.Enabled = false;
            this.txtAtivo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAtivo.Location = new System.Drawing.Point(816, 101);
            this.txtAtivo.Name = "txtAtivo";
            this.txtAtivo.Size = new System.Drawing.Size(169, 31);
            this.txtAtivo.TabIndex = 49;
            // 
            // AtividadeCadView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.txtAtivo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lbId);
            this.Controls.Add(this.SisPS);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridAlunosCad);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.CBoxSalas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CBoxVoluntarios);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lbAtividades);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AtividadeCadView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AtividadeCadView";
            this.Load += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAlunosCad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbAtividades;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CBoxVoluntarios;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CBoxSalas;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView dataGridAlunosCad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DateTimePicker txtData;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label SisPS;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAtivo;
    }
}