﻿namespace TddFizzBuzz
{
    partial class FizzBuzzForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.maxNumberTextbox = new System.Windows.Forms.TextBox();
            this.fizzBuzzButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fizzBuzzDataGirdView1 = new TddFizzBuzz.FizzBuzzDataGirdView();
            ((System.ComponentModel.ISupportInitialize)(this.fizzBuzzDataGirdView1)).BeginInit();
            this.SuspendLayout();
            // 
            // maxNumberTextbox
            // 
            this.maxNumberTextbox.Location = new System.Drawing.Point(47, 14);
            this.maxNumberTextbox.Name = "maxNumberTextbox";
            this.maxNumberTextbox.Size = new System.Drawing.Size(33, 19);
            this.maxNumberTextbox.TabIndex = 0;
            // 
            // fizzBuzzButton
            // 
            this.fizzBuzzButton.Location = new System.Drawing.Point(116, 10);
            this.fizzBuzzButton.Name = "fizzBuzzButton";
            this.fizzBuzzButton.Size = new System.Drawing.Size(138, 23);
            this.fizzBuzzButton.TabIndex = 1;
            this.fizzBuzzButton.Text = "FizzBuzz結果表示！";
            this.fizzBuzzButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "1から";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "まで";
            // 
            // fizzBuzzDataGirdView1
            // 
            this.fizzBuzzDataGirdView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fizzBuzzDataGirdView1.Location = new System.Drawing.Point(12, 39);
            this.fizzBuzzDataGirdView1.Name = "fizzBuzzDataGirdView1";
            this.fizzBuzzDataGirdView1.RowTemplate.Height = 21;
            this.fizzBuzzDataGirdView1.Size = new System.Drawing.Size(240, 211);
            this.fizzBuzzDataGirdView1.TabIndex = 4;
            // 
            // FizzBuzzForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.fizzBuzzDataGirdView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fizzBuzzButton);
            this.Controls.Add(this.maxNumberTextbox);
            this.Name = "FizzBuzzForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.fizzBuzzDataGirdView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox maxNumberTextbox;
        private System.Windows.Forms.Button fizzBuzzButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private FizzBuzzDataGirdView fizzBuzzDataGirdView1;
    }
}
