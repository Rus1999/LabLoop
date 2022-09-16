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
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.plsLabel = New System.Windows.Forms.Label()
        Me.StartNumLabel = New System.Windows.Forms.Label()
        Me.EndNumLabel = New System.Windows.Forms.Label()
        Me.SumOddLabel = New System.Windows.Forms.Label()
        Me.StartValueResultLabel = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.EndValueResultLabel = New System.Windows.Forms.Label()
        Me.ValueLabel = New System.Windows.Forms.Label()
        Me.ValueResultLabel = New System.Windows.Forms.Label()
        Me.CalculateBtn = New System.Windows.Forms.Button()
        Me.StartNumTextbox = New System.Windows.Forms.TextBox()
        Me.EndNumTextbox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'TitleLabel
        '
        Me.TitleLabel.AutoSize = True
        Me.TitleLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.TitleLabel.Location = New System.Drawing.Point(21, 19)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(365, 20)
        Me.TitleLabel.TabIndex = 0
        Me.TitleLabel.Text = "โปรแกรมหาผลรวมของเลขจำนวนคี่ที่มีค่าไม่เกิน 1,000"
        '
        'plsLabel
        '
        Me.plsLabel.AutoSize = True
        Me.plsLabel.Location = New System.Drawing.Point(12, 61)
        Me.plsLabel.Name = "plsLabel"
        Me.plsLabel.Size = New System.Drawing.Size(149, 20)
        Me.plsLabel.TabIndex = 1
        Me.plsLabel.Text = "กรุณาระบุขอบเขตตัวเลข"
        '
        'StartNumLabel
        '
        Me.StartNumLabel.AutoSize = True
        Me.StartNumLabel.Location = New System.Drawing.Point(12, 99)
        Me.StartNumLabel.Name = "StartNumLabel"
        Me.StartNumLabel.Size = New System.Drawing.Size(66, 20)
        Me.StartNumLabel.TabIndex = 2
        Me.StartNumLabel.Text = "เลขเริ่มต้น"
        '
        'EndNumLabel
        '
        Me.EndNumLabel.AutoSize = True
        Me.EndNumLabel.Location = New System.Drawing.Point(181, 99)
        Me.EndNumLabel.Name = "EndNumLabel"
        Me.EndNumLabel.Size = New System.Drawing.Size(64, 20)
        Me.EndNumLabel.TabIndex = 3
        Me.EndNumLabel.Text = "เลขสิ้นสุด"
        '
        'SumOddLabel
        '
        Me.SumOddLabel.AutoSize = True
        Me.SumOddLabel.Location = New System.Drawing.Point(12, 200)
        Me.SumOddLabel.Name = "SumOddLabel"
        Me.SumOddLabel.Size = New System.Drawing.Size(171, 20)
        Me.SumOddLabel.TabIndex = 4
        Me.SumOddLabel.Text = "ผลรวมของเลขจำนวนคี่ตั้งแต่"
        '
        'StartValueResultLabel
        '
        Me.StartValueResultLabel.AutoSize = True
        Me.StartValueResultLabel.ForeColor = System.Drawing.Color.Red
        Me.StartValueResultLabel.Location = New System.Drawing.Point(189, 200)
        Me.StartValueResultLabel.Name = "StartValueResultLabel"
        Me.StartValueResultLabel.Size = New System.Drawing.Size(0, 20)
        Me.StartValueResultLabel.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(221, 200)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(24, 20)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "ถึง"
        '
        'EndValueResultLabel
        '
        Me.EndValueResultLabel.AutoSize = True
        Me.EndValueResultLabel.ForeColor = System.Drawing.Color.Red
        Me.EndValueResultLabel.Location = New System.Drawing.Point(267, 200)
        Me.EndValueResultLabel.Name = "EndValueResultLabel"
        Me.EndValueResultLabel.Size = New System.Drawing.Size(0, 20)
        Me.EndValueResultLabel.TabIndex = 7
        '
        'ValueLabel
        '
        Me.ValueLabel.AutoSize = True
        Me.ValueLabel.Location = New System.Drawing.Point(12, 240)
        Me.ValueLabel.Name = "ValueLabel"
        Me.ValueLabel.Size = New System.Drawing.Size(33, 20)
        Me.ValueLabel.TabIndex = 8
        Me.ValueLabel.Text = "มีค่า"
        '
        'ValueResultLabel
        '
        Me.ValueResultLabel.AutoSize = True
        Me.ValueResultLabel.ForeColor = System.Drawing.Color.Red
        Me.ValueResultLabel.Location = New System.Drawing.Point(78, 240)
        Me.ValueResultLabel.Name = "ValueResultLabel"
        Me.ValueResultLabel.Size = New System.Drawing.Size(0, 20)
        Me.ValueResultLabel.TabIndex = 9
        '
        'CalculateBtn
        '
        Me.CalculateBtn.Location = New System.Drawing.Point(21, 146)
        Me.CalculateBtn.Name = "CalculateBtn"
        Me.CalculateBtn.Size = New System.Drawing.Size(94, 29)
        Me.CalculateBtn.TabIndex = 10
        Me.CalculateBtn.Text = "คำนวณ"
        Me.CalculateBtn.UseVisualStyleBackColor = True
        '
        'StartNumTextbox
        '
        Me.StartNumTextbox.Location = New System.Drawing.Point(106, 96)
        Me.StartNumTextbox.Name = "StartNumTextbox"
        Me.StartNumTextbox.Size = New System.Drawing.Size(55, 27)
        Me.StartNumTextbox.TabIndex = 11
        '
        'EndNumTextbox
        '
        Me.EndNumTextbox.Location = New System.Drawing.Point(267, 96)
        Me.EndNumTextbox.Name = "EndNumTextbox"
        Me.EndNumTextbox.Size = New System.Drawing.Size(55, 27)
        Me.EndNumTextbox.TabIndex = 12
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Pink
        Me.ClientSize = New System.Drawing.Size(412, 276)
        Me.Controls.Add(Me.EndNumTextbox)
        Me.Controls.Add(Me.StartNumTextbox)
        Me.Controls.Add(Me.CalculateBtn)
        Me.Controls.Add(Me.ValueResultLabel)
        Me.Controls.Add(Me.ValueLabel)
        Me.Controls.Add(Me.EndValueResultLabel)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.StartValueResultLabel)
        Me.Controls.Add(Me.SumOddLabel)
        Me.Controls.Add(Me.EndNumLabel)
        Me.Controls.Add(Me.StartNumLabel)
        Me.Controls.Add(Me.plsLabel)
        Me.Controls.Add(Me.TitleLabel)
        Me.Name = "Form1"
        Me.Text = "ผลรวมเลขจำนวนคี่"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TitleLabel As Label
    Friend WithEvents plsLabel As Label
    Friend WithEvents StartNumLabel As Label
    Friend WithEvents EndNumLabel As Label
    Friend WithEvents SumOddLabel As Label
    Friend WithEvents StartValueResultLabel As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents EndValueResultLabel As Label
    Friend WithEvents ValueLabel As Label
    Friend WithEvents ValueResultLabel As Label
    Friend WithEvents CalculateBtn As Button
    Friend WithEvents StartNumTextbox As TextBox
    Friend WithEvents EndNumTextbox As TextBox
End Class
