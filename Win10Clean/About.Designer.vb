﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class About
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
<<<<<<< HEAD
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(About))
        Me.CloseBtn = New System.Windows.Forms.Button()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'CloseBtn
        '
        Me.CloseBtn.Location = New System.Drawing.Point(292, 240)
        Me.CloseBtn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CloseBtn.Name = "CloseBtn"
        Me.CloseBtn.Size = New System.Drawing.Size(58, 19)
        Me.CloseBtn.TabIndex = 1
        Me.CloseBtn.Text = "Go back"
        Me.CloseBtn.UseVisualStyleBackColor = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(9, 10)
        Me.RichTextBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.Size = New System.Drawing.Size(343, 227)
        Me.RichTextBox1.TabIndex = 2
        Me.RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        '
        'About
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(360, 269)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.CloseBtn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "About"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "About"
        Me.ResumeLayout(False)

=======
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(About))
        Me.CloseBtn = New System.Windows.Forms.Button()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'CloseBtn
        '
        Me.CloseBtn.Location = New System.Drawing.Point(292, 240)
        Me.CloseBtn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CloseBtn.Name = "CloseBtn"
        Me.CloseBtn.Size = New System.Drawing.Size(58, 19)
        Me.CloseBtn.TabIndex = 1
        Me.CloseBtn.Text = "Go back"
        Me.CloseBtn.UseVisualStyleBackColor = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(9, 10)
        Me.RichTextBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.Size = New System.Drawing.Size(343, 227)
        Me.RichTextBox1.TabIndex = 2
        Me.RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        '
        'About
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(360, 269)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.CloseBtn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "About"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "About"
        Me.ResumeLayout(False)

>>>>>>> 433da21d71ca600d63d67a18d5bea5bc47e3de2f
    End Sub
    Friend WithEvents CloseBtn As Button
    Friend WithEvents RichTextBox1 As RichTextBox
End Class
