<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMoveItemListBox
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.btnMoveRight = New System.Windows.Forms.Button()
        Me.btnMoveLeft = New System.Windows.Forms.Button()
        Me.btnMoveAllRight = New System.Windows.Forms.Button()
        Me.btnMoveAllLeft = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnMoveUp = New System.Windows.Forms.Button()
        Me.btnMoveDown = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(24, 40)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.ListBox1.Size = New System.Drawing.Size(183, 356)
        Me.ListBox1.TabIndex = 0
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.ItemHeight = 16
        Me.ListBox2.Location = New System.Drawing.Point(273, 40)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.ListBox2.Size = New System.Drawing.Size(183, 356)
        Me.ListBox2.TabIndex = 5
        '
        'btnMoveRight
        '
        Me.btnMoveRight.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMoveRight.Location = New System.Drawing.Point(213, 55)
        Me.btnMoveRight.Name = "btnMoveRight"
        Me.btnMoveRight.Size = New System.Drawing.Size(54, 26)
        Me.btnMoveRight.TabIndex = 1
        Me.btnMoveRight.Text = ">"
        Me.btnMoveRight.UseVisualStyleBackColor = True
        '
        'btnMoveLeft
        '
        Me.btnMoveLeft.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMoveLeft.Location = New System.Drawing.Point(213, 88)
        Me.btnMoveLeft.Name = "btnMoveLeft"
        Me.btnMoveLeft.Size = New System.Drawing.Size(54, 26)
        Me.btnMoveLeft.TabIndex = 2
        Me.btnMoveLeft.Text = "<"
        Me.btnMoveLeft.UseVisualStyleBackColor = True
        '
        'btnMoveAllRight
        '
        Me.btnMoveAllRight.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMoveAllRight.Location = New System.Drawing.Point(213, 121)
        Me.btnMoveAllRight.Name = "btnMoveAllRight"
        Me.btnMoveAllRight.Size = New System.Drawing.Size(54, 26)
        Me.btnMoveAllRight.TabIndex = 3
        Me.btnMoveAllRight.Text = ">>"
        Me.btnMoveAllRight.UseVisualStyleBackColor = True
        '
        'btnMoveAllLeft
        '
        Me.btnMoveAllLeft.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMoveAllLeft.Location = New System.Drawing.Point(213, 154)
        Me.btnMoveAllLeft.Name = "btnMoveAllLeft"
        Me.btnMoveAllLeft.Size = New System.Drawing.Size(54, 26)
        Me.btnMoveAllLeft.TabIndex = 4
        Me.btnMoveAllLeft.Text = "<<"
        Me.btnMoveAllLeft.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 16)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "รายการที่ 1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(270, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 16)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "รายการที่ 2"
        '
        'btnMoveUp
        '
        Me.btnMoveUp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMoveUp.Location = New System.Drawing.Point(462, 55)
        Me.btnMoveUp.Name = "btnMoveUp"
        Me.btnMoveUp.Size = New System.Drawing.Size(54, 26)
        Me.btnMoveUp.TabIndex = 6
        Me.btnMoveUp.Text = "UP"
        Me.btnMoveUp.UseVisualStyleBackColor = True
        '
        'btnMoveDown
        '
        Me.btnMoveDown.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMoveDown.Location = New System.Drawing.Point(462, 88)
        Me.btnMoveDown.Name = "btnMoveDown"
        Me.btnMoveDown.Size = New System.Drawing.Size(54, 26)
        Me.btnMoveDown.TabIndex = 7
        Me.btnMoveDown.Text = "DOWN"
        Me.btnMoveDown.UseVisualStyleBackColor = True
        '
        'frmMoveItemListBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(520, 416)
        Me.Controls.Add(Me.btnMoveDown)
        Me.Controls.Add(Me.btnMoveUp)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnMoveAllLeft)
        Me.Controls.Add(Me.btnMoveAllRight)
        Me.Controls.Add(Me.btnMoveLeft)
        Me.Controls.Add(Me.btnMoveRight)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.ListBox1)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMoveItemListBox"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Move Item from ListBox to ListBox - coDe bY: Thongkorn Tubtimkrob"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents ListBox2 As System.Windows.Forms.ListBox
    Friend WithEvents btnMoveRight As System.Windows.Forms.Button
    Friend WithEvents btnMoveLeft As System.Windows.Forms.Button
    Friend WithEvents btnMoveAllRight As System.Windows.Forms.Button
    Friend WithEvents btnMoveAllLeft As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnMoveUp As System.Windows.Forms.Button
    Friend WithEvents btnMoveDown As System.Windows.Forms.Button

End Class
