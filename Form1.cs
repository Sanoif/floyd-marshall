using System;
using System.Windows.Forms;

namespace floyd_marshall
{
    public partial class Form1 : Form
    {
        private int[,] startMatrix;
        private int INF = int.MaxValue;

        public Form1()
        {
            InitializeComponent();
        }

        private void bBuildMatrix_Click(object sender, EventArgs e)
        {
            ClearGraph();
            dgvStartMatrix.RowCount = Convert.ToInt32(tbNumberOfVertex.Text);
            dgvStartMatrix.ColumnCount = Convert.ToInt32(tbNumberOfVertex.Text);
            int matrixSize = dgvStartMatrix.RowCount;
            startMatrix = new int[matrixSize, matrixSize];

            dgvChangedMatrix.RowCount = Convert.ToInt32(tbNumberOfVertex.Text);
            dgvChangedMatrix.ColumnCount = Convert.ToInt32(tbNumberOfVertex.Text);
            ChangeHeadersNames();
        }

        private void bRndValues_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int matrixSize = dgvStartMatrix.RowCount;

            for (int i = 0; i < matrixSize; i++)
            {
                for (int j = 0; j < matrixSize; j++)
                {
                    if (i == j)
                    {
                        startMatrix[i, j] = 0;
                        continue;
                    }
                    startMatrix[i, j] = rnd.Next(0, 200);
                }
            }

            for (int i = 0; i < matrixSize; i++)
                for (int j = 0; j < matrixSize; j++)
                    dgvStartMatrix.Rows[i].Cells[j].Value = startMatrix[i, j].ToString();
        }

        private void bAddVertex_Click(object sender, EventArgs e)
        {
            int size = Convert.ToInt32(tbAddVertex.Text);
            for (int i = 0; i < size; i++)
            {
                dgvStartMatrix.Rows.Add();
                dgvStartMatrix.Columns.Add("0", "0");
                dgvChangedMatrix.Rows.Add();
                dgvChangedMatrix.Columns.Add("0", "0");
            }
            ChangeHeadersNames();
            startMatrix = ResizeArray(startMatrix, dgvStartMatrix.RowCount, dgvStartMatrix.ColumnCount);
        }
        private T[,] ResizeArray<T>(T[,] original, int rows, int cols)
        {
            var newArray = new T[rows, cols];
            int minRows = Math.Min(rows, original.GetLength(0));
            int minCols = Math.Min(cols, original.GetLength(1));
            for (int i = 0; i < minRows; i++)
                for (int j = 0; j < minCols; j++)
                    newArray[i, j] = original[i, j];
            return newArray;
        }

        private void bDeleteGraph_Click(object sender, EventArgs e)
        {
            ClearGraph();
        }

        private void ClearGraph()
        {
            dgvStartMatrix.Rows.Clear();
            dgvStartMatrix.Columns.Clear();
            dgvStartMatrix.Refresh();
            dgvChangedMatrix.Rows.Clear();
            dgvChangedMatrix.Columns.Clear();
            dgvChangedMatrix.Refresh();
        }

        private void ChangeHeadersNames()
        {
            int size = dgvStartMatrix.RowCount;
            for (int i = 0; i < size; i++)
            {
                dgvStartMatrix.Columns[i].HeaderText = i.ToString();
                dgvStartMatrix.Rows[i].HeaderCell.Value = i.ToString();
                dgvChangedMatrix.Columns[i].HeaderText = i.ToString();
                dgvChangedMatrix.Rows[i].HeaderCell.Value = i.ToString();
            }
        }

        private void bFindWay_Click(object sender, EventArgs e)
        {
            int matrixSize = dgvStartMatrix.RowCount;
            int[,] changedMatrix = new int[matrixSize, matrixSize];

            for (int k = 0; k < matrixSize; ++k)
                for (int i = 0; i < matrixSize; ++i)
                    for (int j = 0; j < matrixSize; ++j)
                        changedMatrix[i, j] = Math.Min(startMatrix[i, j], startMatrix[i, k] + startMatrix[k, j]);

            for (int i = 0; i < matrixSize; i++) 
            {
                for (int j = 0; j < matrixSize; j++)
                {
                    dgvChangedMatrix.Rows[i].Cells[j].Value = changedMatrix[i, j].ToString();
                    Console.WriteLine(changedMatrix[i, j]);
                }
            Console.WriteLine();
            }
        }

        private void dgvStartMatrix_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            startMatrix[e.RowIndex, e.ColumnIndex] = Convert.ToInt32(dgvStartMatrix[e.RowIndex, e.ColumnIndex].Value);
        }

        private void bShowGraph_Click(object sender, EventArgs e)
        {
            Form Form2 = new Form();
            Microsoft.Msagl.GraphViewerGdi.GViewer viewer = new Microsoft.Msagl.GraphViewerGdi.GViewer();
            Microsoft.Msagl.Drawing.Graph graph = new Microsoft.Msagl.Drawing.Graph("graph");
            for (int i = 0; i < dgvStartMatrix.RowCount; i++)
            {
                for (int j = 0; j < dgvStartMatrix.RowCount; j++)
                {
                    if(i != j)
                        graph.AddEdge(i.ToString(), j.ToString());
                }
            }
            viewer.Graph = graph;
            Form2.SuspendLayout();
            viewer.Dock = System.Windows.Forms.DockStyle.Fill;
            Form2.Controls.Add(viewer);
            Form2.ResumeLayout();
            Form2.ShowDialog();
        }
    }
}
