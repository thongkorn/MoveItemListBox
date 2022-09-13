#Region "ABOUT"
' / ------------------------------------------------------------------------------
' / Developer : Mr.Surapon Yodsanga (Thongkorn Tubtimkrob)
' / eMail : thongkorn@hotmail.com
' / URL: http://www.g2gnet.com (Khon Kaen - Thailand)
' / Facebook: https://www.facebook.com/g2gnet (For Thailand)
' / Facebook: https://www.facebook.com/commonindy (Worldwide)
' / More Info: http://www.g2gsoft.com
' /
' / Purpose: Transfer Items Between 2 ListBoxes and Move Up/Down Item.
' / Microsoft Visual Basic .NET (2010)
' /
' / This is open source code under @CopyLeft by Thongkorn Tubtimkrob.
' / You can modify and/or distribute without to inform the developer.
' / ------------------------------------------------------------------------------
#End Region

Public Class frmMoveItemListBox

    Private Sub frmMoveItemListBox_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        '// ใส่ค่าไอเทมตัวอย่าง
        With ListBox1
            .Items.Add("Computer")
            .Items.Add("Processor")
            .Items.Add("Notebook")
            .Items.Add("Mouse")
            .Items.Add("Keyboard")
            .Items.Add("Power Supply")
            .Items.Add("Monitor")
        End With
        '// เลือกไอเทมได้ทีละตัว
        'ListBox1.SelectionMode = SelectionMode.One
        'ListBox2.SelectionMode = SelectionMode.One
        '// เพิ่มคำอธิบาย (ToolTip) บนปุ่มคำสั่งแต่ละตัว
        Dim MyToolTip As New ToolTip
        With MyToolTip
            .SetToolTip(Me.btnMoveRight, "ย้ายไอเทมที่เลือกไปทางขวา")
            .SetToolTip(Me.btnMoveLeft, "ย้ายไอเทมที่เลือกไปทางซ้าย")
            .SetToolTip(Me.btnMoveAllRight, "ย้ายไอเทมทั้งหมดไปทางขวา")
            .SetToolTip(Me.btnMoveAllLeft, "ย้ายไอเทมทั้งหมดไปทางซ้าย")
            .SetToolTip(Me.btnMoveUp, "ย้ายไอเทมที่เลือกขึ้นไปด้านบน")
            .SetToolTip(Me.btnMoveDown, "ย้ายไอเทมที่เลือกลงไปด้านล่าง")
        End With
    End Sub

    ' / ------------------------------------------------------------------------------
    '// เลื่อน Item ขึ้น
    Private Sub btnMoveUp_Click(sender As System.Object, e As System.EventArgs) Handles btnMoveUp.Click
        '// Trap Error: หากไม่มีการเลือกไอเทม ก็ให้เด้งหนีออกไป
        If ListBox2.SelectedItem = Nothing Then Exit Sub
        '// การเลื่อนไอเทมขึ้น ไอเทมที่เลือกต้องมากกว่า 0 เพราะหาก SelectedIndex = 0 ก็คือแถวบนสุด จะออกจากเงื่อนไข
        If ListBox2.SelectedIndex > 0 Then
            '// การเลื่อนขึ้นไปข้างบนต้องทำการลดค่า SelectedIndex ลง 1 ค่า
            Dim iRow As Integer = ListBox2.SelectedIndex - 1
            '// แทรกไอเทมในแถวที่เลื่อนขึ้นไป
            ListBox2.Items.Insert(iRow, ListBox2.SelectedItem)
            '// ลบแถวตัวมันเองออกไป
            ListBox2.Items.RemoveAt(ListBox2.SelectedIndex)
            '// เลือกแถวปัจจุบันที่ถูกเลื่อนขึ้น
            ListBox2.SelectedIndex = iRow
        End If
    End Sub

    ' / ------------------------------------------------------------------------------
    '// เลื่อน Item ลง
    Private Sub btnMoveDown_Click(sender As System.Object, e As System.EventArgs) Handles btnMoveDown.Click
        '// Trap Error: หากไม่มีการเลือกไอเทม ก็ให้เด้งหนีออกไป
        If ListBox2.SelectedItem = Nothing Then Exit Sub
        '// ไอเทมที่เลือกต้องน้อยกว่า จำนวนไอเทมทั้งหมดลบ 1 (Index นับที่ 0)
        '// หากไอเทมที่เลือกมีค่าเท่ากับ ListBox2.Items.Count - 1 มันคือแถวลำดับสุดท้าย จะออกจากเงื่อนไข
        If ListBox2.SelectedIndex < ListBox2.Items.Count - 1 Then
            '// การเลื่อนแถวลง ต้องเลื่อนลงไปข้างล่าง 2 แถวก่อน เพราะการ Insert จะแทรกแถวขึ้นมาด้านบน 1 แถว
            Dim iRow As Integer = ListBox2.SelectedIndex + 2
            '// แทรกแถวไอเทมใหม่
            ListBox2.Items.Insert(iRow, ListBox2.SelectedItem)
            '// ลบแถวตัวมันเองออกไป
            ListBox2.Items.RemoveAt(ListBox2.SelectedIndex)
            '// ลบออก 1 เพื่อเลือกแถวที่เลื่อนลงไป
            ListBox2.SelectedIndex = iRow - 1
        End If
    End Sub

    ' / ------------------------------------------------------------------------------
    ' / ย้ายไอเทมจาก ListBox1 ไป ListBox2
    Private Sub btnMoveRight_Click(sender As System.Object, e As System.EventArgs) Handles btnMoveRight.Click
        '// ยังไม่ได้เลือกไอเทม
        If ListBox1.SelectedIndex < 0 Then
            MessageBox.Show("กรุณาเลือกไอเทมในรายการที่ 1 ก่อน.", "รายงานสถานะ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            '// เพิ่มไอเทมที่เลือกจาก ListBox1 ไปให้กับ ListBox2
            'ListBox2.Items.Add(ListBox1.SelectedItem)
            '// ลบไอเทมที่เลือกใน ListBox1 ออกไป
            'ListBox1.Items.Remove(ListBox1.SelectedItem)

            '// เก็บค่าไอเทมเอาไว้ใน Array แต่เป็นการจัดการเก็บสมาชิก (Collection) ในรูปแบบ List 
            Dim mSelectItem = (From i In ListBox1.SelectedItems).ToList
            '// วนรอบจากค่าไอเทมที่มีอยู่
            For Each item In mSelectItem
                '// เพิ่มไอเทมที่เลือกจาก ListBox1 ไปให้กับ ListBox2
                ListBox2.Items.Add(ListBox1.SelectedItem)
                '// ลบไอเทมที่เลือกใน ListBox1 ออกไป
                ListBox1.Items.Remove(ListBox1.SelectedItem)
            Next
        End If
    End Sub

    ' / ------------------------------------------------------------------------------
    ' / ย้ายไอเทมจาก ListBox2 ไป ListBox1
    Private Sub btnMoveLeft_Click(sender As System.Object, e As System.EventArgs) Handles btnMoveLeft.Click
        If ListBox2.SelectedIndex < 0 Then
            MessageBox.Show("กรุณาเลือกไอเทมในรายการที่ 2 ก่อน.", "รายงานสถานะ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            '// เพิ่มไอเทมที่เลือกจาก ListBox2 ไปให้กับ ListBox1
            'ListBox1.Items.Add(ListBox2.SelectedItem)
            '// ลบไอเทมที่เลือกใน ListBox2 ออกไป
            'ListBox2.Items.Remove(ListBox2.SelectedItem)

            '// เก็บค่าไอเทมเอาไว้ใน List 
            Dim mSelectItem = (From i In ListBox2.SelectedItems).ToList
            '// วนรอบจากค่าไอเทมที่มีอยู่
            For Each item In mSelectItem
                '// เพิ่มไอเทมที่เลือกจาก ListBox1 ไปให้กับ ListBox2
                ListBox1.Items.Add(ListBox2.SelectedItem)
                '// ลบไอเทมที่เลือกใน ListBox1 ออกไป
                ListBox2.Items.Remove(ListBox2.SelectedItem)
            Next
        End If

    End Sub

    ' / ------------------------------------------------------------------------------
    ' / ย้ายไอเทมทั้งหมดจาก ListBox1 ไป ListBox2
    Private Sub btnMoveAllRight_Click(sender As System.Object, e As System.EventArgs) Handles btnMoveAllRight.Click
        '// ลูปเอาไอเทมทั้งหมดที่มีอยู่ใน ListBox1 ไปให้กับ ListBox2
        For Each item In ListBox1.Items
            ListBox2.Items.Add(item)
        Next
        '// ลบไอเทมที่มีอยู่ทั้งหมดใน ListBox1 ออกไป
        ListBox1.Items.Clear()
    End Sub

    ' / ------------------------------------------------------------------------------
    ' / ย้ายไอเทมทั้งหมดจาก ListBox2 ไป ListBox1
    Private Sub btnMoveAllLeft_Click(sender As System.Object, e As System.EventArgs) Handles btnMoveAllLeft.Click
        '// ลูปเอาไอเทมทั้งหมดที่มีอยู่ใน ListBox2 ไปให้กับ ListBox1
        For Each item In ListBox2.Items
            ListBox1.Items.Add(item)
        Next
        '// ลบไอเทมที่มีอยู่ทั้งหมดใน ListBox2 ออกไป
        ListBox2.Items.Clear()
    End Sub

End Class
