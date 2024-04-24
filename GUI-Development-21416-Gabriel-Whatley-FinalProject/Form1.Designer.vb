<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        GroupBox1 = New GroupBox()
        TextBox1 = New TextBox()
        rdio_In_to_M = New RadioButton()
        rdio_M_to_In = New RadioButton()
        btn_convert = New Button()
        lbl_conversion_output = New Label()
        btn_save_results = New Button()
        btn_clear_results = New Button()
        lbl_save_msg = New Label()
        listbox_results = New ListBox()
        btn_clear_list = New Button()
        btn_save_list = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.building
        PictureBox1.Location = New Point(12, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(274, 211)
        PictureBox1.SizeMode = PictureBoxSizeMode.AutoSize
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(367, 37)
        Label1.Name = "Label1"
        Label1.Size = New Size(93, 15)
        Label1.TabIndex = 1
        Label1.Text = "Converter App 2"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(367, 89)
        Label2.Name = "Label2"
        Label2.Size = New Size(106, 30)
        Label2.TabIndex = 2
        Label2.Text = "Enter a value and " & vbCrLf & "choose conversion"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(rdio_M_to_In)
        GroupBox1.Controls.Add(rdio_In_to_M)
        GroupBox1.Location = New Point(367, 167)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(200, 132)
        GroupBox1.TabIndex = 3
        GroupBox1.TabStop = False
        GroupBox1.Text = "Convert Measurement"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(500, 93)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(149, 23)
        TextBox1.TabIndex = 4
        ' 
        ' rdio_In_to_M
        ' 
        rdio_In_to_M.AutoSize = True
        rdio_In_to_M.Location = New Point(27, 37)
        rdio_In_to_M.Name = "rdio_In_to_M"
        rdio_In_to_M.Size = New Size(112, 19)
        rdio_In_to_M.TabIndex = 0
        rdio_In_to_M.TabStop = True
        rdio_In_to_M.Text = "Inches to Meters"
        rdio_In_to_M.UseVisualStyleBackColor = True
        ' 
        ' rdio_M_to_In
        ' 
        rdio_M_to_In.AutoSize = True
        rdio_M_to_In.Location = New Point(27, 83)
        rdio_M_to_In.Name = "rdio_M_to_In"
        rdio_M_to_In.Size = New Size(112, 19)
        rdio_M_to_In.TabIndex = 1
        rdio_M_to_In.TabStop = True
        rdio_M_to_In.Text = "Meters to Inches"
        rdio_M_to_In.UseVisualStyleBackColor = True
        ' 
        ' btn_convert
        ' 
        btn_convert.Location = New Point(374, 335)
        btn_convert.Name = "btn_convert"
        btn_convert.Size = New Size(75, 23)
        btn_convert.TabIndex = 5
        btn_convert.Text = "Convert"
        btn_convert.UseVisualStyleBackColor = True
        ' 
        ' lbl_conversion_output
        ' 
        lbl_conversion_output.AutoSize = True
        lbl_conversion_output.Location = New Point(374, 386)
        lbl_conversion_output.Name = "lbl_conversion_output"
        lbl_conversion_output.Size = New Size(107, 15)
        lbl_conversion_output.TabIndex = 6
        lbl_conversion_output.Text = "Conversion Results"
        ' 
        ' btn_save_results
        ' 
        btn_save_results.Location = New Point(374, 431)
        btn_save_results.Name = "btn_save_results"
        btn_save_results.Size = New Size(129, 23)
        btn_save_results.TabIndex = 7
        btn_save_results.Text = "Save Results"
        btn_save_results.UseVisualStyleBackColor = True
        ' 
        ' btn_clear_results
        ' 
        btn_clear_results.Location = New Point(373, 482)
        btn_clear_results.Name = "btn_clear_results"
        btn_clear_results.Size = New Size(130, 23)
        btn_clear_results.TabIndex = 8
        btn_clear_results.Text = "Clear Results"
        btn_clear_results.UseVisualStyleBackColor = True
        ' 
        ' lbl_save_msg
        ' 
        lbl_save_msg.AutoSize = True
        lbl_save_msg.Location = New Point(374, 544)
        lbl_save_msg.Name = "lbl_save_msg"
        lbl_save_msg.Size = New Size(80, 15)
        lbl_save_msg.TabIndex = 9
        lbl_save_msg.Text = "Save Message"
        ' 
        ' listbox_results
        ' 
        listbox_results.FormattingEnabled = True
        listbox_results.ItemHeight = 15
        listbox_results.Location = New Point(31, 255)
        listbox_results.Name = "listbox_results"
        listbox_results.Size = New Size(255, 274)
        listbox_results.TabIndex = 10
        ' 
        ' btn_clear_list
        ' 
        btn_clear_list.Location = New Point(31, 544)
        btn_clear_list.Name = "btn_clear_list"
        btn_clear_list.Size = New Size(107, 23)
        btn_clear_list.TabIndex = 11
        btn_clear_list.Text = "Clear List"
        btn_clear_list.UseVisualStyleBackColor = True
        ' 
        ' btn_save_list
        ' 
        btn_save_list.Location = New Point(180, 544)
        btn_save_list.Name = "btn_save_list"
        btn_save_list.Size = New Size(106, 23)
        btn_save_list.TabIndex = 12
        btn_save_list.Text = "Save to File"
        btn_save_list.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 668)
        Controls.Add(btn_save_list)
        Controls.Add(btn_clear_list)
        Controls.Add(listbox_results)
        Controls.Add(lbl_save_msg)
        Controls.Add(btn_clear_results)
        Controls.Add(btn_save_results)
        Controls.Add(lbl_conversion_output)
        Controls.Add(btn_convert)
        Controls.Add(TextBox1)
        Controls.Add(GroupBox1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Name = "Form1"
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rdio_M_to_In As RadioButton
    Friend WithEvents rdio_In_to_M As RadioButton
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btn_convert As Button
    Friend WithEvents lbl_conversion_output As Label
    Friend WithEvents btn_save_results As Button
    Friend WithEvents btn_clear_results As Button
    Friend WithEvents lbl_save_msg As Label
    Friend WithEvents listbox_results As ListBox
    Friend WithEvents btn_clear_list As Button
    Friend WithEvents btn_save_list As Button

End Class
