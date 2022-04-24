namespace floyd_marshall
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNumberOfVertex = new System.Windows.Forms.TextBox();
            this.tbAddVertex = new System.Windows.Forms.TextBox();
            this.bBuildMatrix = new System.Windows.Forms.Button();
            this.bAddVertex = new System.Windows.Forms.Button();
            this.bDeleteGraph = new System.Windows.Forms.Button();
            this.bRndValues = new System.Windows.Forms.Button();
            this.bFindWay = new System.Windows.Forms.Button();
            this.bShowGraph = new System.Windows.Forms.Button();
            this.dgvStartMatrix = new System.Windows.Forms.DataGridView();
            this.dgvChangedMatrix = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStartMatrix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChangedMatrix)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Кол-во вершин графа:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Добавить доп. вершины:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(307, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Матрица расстояний:";
            // 
            // tbNumberOfVertex
            // 
            this.tbNumberOfVertex.Location = new System.Drawing.Point(15, 40);
            this.tbNumberOfVertex.Name = "tbNumberOfVertex";
            this.tbNumberOfVertex.Size = new System.Drawing.Size(116, 20);
            this.tbNumberOfVertex.TabIndex = 3;
            // 
            // tbAddVertex
            // 
            this.tbAddVertex.Location = new System.Drawing.Point(151, 40);
            this.tbAddVertex.Name = "tbAddVertex";
            this.tbAddVertex.Size = new System.Drawing.Size(116, 20);
            this.tbAddVertex.TabIndex = 4;
            // 
            // bBuildMatrix
            // 
            this.bBuildMatrix.Location = new System.Drawing.Point(15, 85);
            this.bBuildMatrix.Name = "bBuildMatrix";
            this.bBuildMatrix.Size = new System.Drawing.Size(116, 50);
            this.bBuildMatrix.TabIndex = 5;
            this.bBuildMatrix.Text = "Построить граф";
            this.bBuildMatrix.UseVisualStyleBackColor = true;
            this.bBuildMatrix.Click += new System.EventHandler(this.bBuildMatrix_Click);
            // 
            // bAddVertex
            // 
            this.bAddVertex.Location = new System.Drawing.Point(151, 85);
            this.bAddVertex.Name = "bAddVertex";
            this.bAddVertex.Size = new System.Drawing.Size(116, 50);
            this.bAddVertex.TabIndex = 6;
            this.bAddVertex.Text = "Добавить вершины";
            this.bAddVertex.UseVisualStyleBackColor = true;
            this.bAddVertex.Click += new System.EventHandler(this.bAddVertex_Click);
            // 
            // bDeleteGraph
            // 
            this.bDeleteGraph.Location = new System.Drawing.Point(15, 156);
            this.bDeleteGraph.Name = "bDeleteGraph";
            this.bDeleteGraph.Size = new System.Drawing.Size(116, 50);
            this.bDeleteGraph.TabIndex = 7;
            this.bDeleteGraph.Text = "Удалить граф";
            this.bDeleteGraph.UseVisualStyleBackColor = true;
            this.bDeleteGraph.Click += new System.EventHandler(this.bDeleteGraph_Click);
            // 
            // bRndValues
            // 
            this.bRndValues.Location = new System.Drawing.Point(60, 227);
            this.bRndValues.Name = "bRndValues";
            this.bRndValues.Size = new System.Drawing.Size(171, 50);
            this.bRndValues.TabIndex = 8;
            this.bRndValues.Text = "Случайные значения";
            this.bRndValues.UseVisualStyleBackColor = true;
            this.bRndValues.Click += new System.EventHandler(this.bRndValues_Click);
            // 
            // bFindWay
            // 
            this.bFindWay.Location = new System.Drawing.Point(60, 297);
            this.bFindWay.Name = "bFindWay";
            this.bFindWay.Size = new System.Drawing.Size(171, 50);
            this.bFindWay.TabIndex = 9;
            this.bFindWay.Text = "Найти кратчайший путь";
            this.bFindWay.UseVisualStyleBackColor = true;
            this.bFindWay.Click += new System.EventHandler(this.bFindWay_Click);
            // 
            // bShowGraph
            // 
            this.bShowGraph.Location = new System.Drawing.Point(60, 365);
            this.bShowGraph.Name = "bShowGraph";
            this.bShowGraph.Size = new System.Drawing.Size(171, 50);
            this.bShowGraph.TabIndex = 10;
            this.bShowGraph.Text = "Визуализация графа";
            this.bShowGraph.UseVisualStyleBackColor = true;
            this.bShowGraph.Click += new System.EventHandler(this.bShowGraph_Click);
            // 
            // dgvStartMatrix
            // 
            this.dgvStartMatrix.AllowUserToAddRows = false;
            this.dgvStartMatrix.AllowUserToDeleteRows = false;
            this.dgvStartMatrix.AllowUserToResizeColumns = false;
            this.dgvStartMatrix.AllowUserToResizeRows = false;
            this.dgvStartMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStartMatrix.Location = new System.Drawing.Point(310, 40);
            this.dgvStartMatrix.Name = "dgvStartMatrix";
            this.dgvStartMatrix.Size = new System.Drawing.Size(478, 237);
            this.dgvStartMatrix.TabIndex = 11;
            this.dgvStartMatrix.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStartMatrix_CellEndEdit);
            // 
            // dgvChangedMatrix
            // 
            this.dgvChangedMatrix.AllowUserToAddRows = false;
            this.dgvChangedMatrix.AllowUserToDeleteRows = false;
            this.dgvChangedMatrix.AllowUserToResizeColumns = false;
            this.dgvChangedMatrix.AllowUserToResizeRows = false;
            this.dgvChangedMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChangedMatrix.Location = new System.Drawing.Point(310, 347);
            this.dgvChangedMatrix.Name = "dgvChangedMatrix";
            this.dgvChangedMatrix.Size = new System.Drawing.Size(478, 237);
            this.dgvChangedMatrix.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(307, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(293, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Кратчайший путь в графе(Алгоритм Флойда-Уоршелла):";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 596);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvChangedMatrix);
            this.Controls.Add(this.dgvStartMatrix);
            this.Controls.Add(this.bShowGraph);
            this.Controls.Add(this.bFindWay);
            this.Controls.Add(this.bRndValues);
            this.Controls.Add(this.bDeleteGraph);
            this.Controls.Add(this.bAddVertex);
            this.Controls.Add(this.bBuildMatrix);
            this.Controls.Add(this.tbAddVertex);
            this.Controls.Add(this.tbNumberOfVertex);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStartMatrix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChangedMatrix)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNumberOfVertex;
        private System.Windows.Forms.TextBox tbAddVertex;
        private System.Windows.Forms.Button bBuildMatrix;
        private System.Windows.Forms.Button bAddVertex;
        private System.Windows.Forms.Button bDeleteGraph;
        private System.Windows.Forms.Button bRndValues;
        private System.Windows.Forms.Button bFindWay;
        private System.Windows.Forms.Button bShowGraph;
        private System.Windows.Forms.DataGridView dgvStartMatrix;
        private System.Windows.Forms.DataGridView dgvChangedMatrix;
        private System.Windows.Forms.Label label4;
    }
}

