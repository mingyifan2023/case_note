Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' 创建包含数据的 List 对象
        Dim dataList As New List(Of Double())()
        'dataList.Add(New Double() {0.1, 99999, 99999})
        dataList.Add(New Double() {1.2, 2, 22})
        dataList.Add(New Double() {3, 3, 34})
        dataList.Add(New Double() {4, 0, 33})
        dataList.Add(New Double() {5, 4, 27})

        ' 设置 DataGridView 的列数和行数
        DataGridView1.ColumnCount = 3
        DataGridView1.RowCount = 5

        ' 设置列名
        DataGridView1.Columns(0).HeaderText = "start"
        DataGridView1.Columns(1).HeaderText = "end"
        DataGridView1.Columns(2).HeaderText = "comment"

        ' 将数据绑定到 DataGridView 控件 添加的部分需要进行分歧判断，展示的部分也需要进行分歧判断

        For i As Integer = 0 To dataList.Count - 1
            If dataList(i)(0) = 0.1 And dataList(i)(1) = 99999 And dataList(i)(2) = 99999 Then
                DataGridView1.Rows(i).Cells(0).Value = dataList(i)(0)
                ' 其他两个单元格为空
            Else
                DataGridView1.Rows(i).Cells(0).Value = dataList(i)(0)
                DataGridView1.Rows(i).Cells(1).Value = dataList(i)(1)
                DataGridView1.Rows(i).Cells(2).Value = dataList(i)(2)
            End If
        Next

        ' 调整表格大小
        For Each column As DataGridViewColumn In DataGridView1.Columns
            column.Width = 50  ' 设置列宽
        Next

        For Each row As DataGridViewRow In DataGridView1.Rows
            row.Height = 30  ' 设置行高
        Next
    End Sub
End Class
