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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Button1 = New Button()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        Label5 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(120, 72)
        Label1.Name = "Label1"
        Label1.Size = New Size(100, 15)
        Label1.TabIndex = 0
        Label1.Text = "Enter your weight"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(120, 122)
        Label2.Name = "Label2"
        Label2.Size = New Size(120, 15)
        Label2.TabIndex = 1
        Label2.Text = "Enter your height (m)"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(120, 169)
        Label3.Name = "Label3"
        Label3.Size = New Size(55, 15)
        Label3.TabIndex = 2
        Label3.Text = "Your BMI"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(120, 222)
        Label4.Name = "Label4"
        Label4.Size = New Size(61, 15)
        Label4.TabIndex = 3
        Label4.Text = "Comment"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.PaleTurquoise
        Button1.Font = New Font("Sitka Banner", 14.2499981F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(63, 264)
        Button1.Name = "Button1"
        Button1.Size = New Size(118, 57)
        Button1.TabIndex = 4
        Button1.Text = "Calculate"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(323, 64)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(100, 23)
        TextBox1.TabIndex = 5
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(323, 114)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(100, 23)
        TextBox2.TabIndex = 6
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(323, 166)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(100, 23)
        TextBox3.TabIndex = 7
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(323, 219)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(100, 23)
        TextBox4.TabIndex = 8
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("MS Gothic", 15.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.Indigo
        Label5.Location = New Point(221, 28)
        Label5.Name = "Label5"
        Label5.Size = New Size(190, 21)
        Label5.TabIndex = 9
        Label5.Text = "KNOW YOUR BMI!!"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Cyan
        ClientSize = New Size(800, 450)
        Controls.Add(Label5)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Button1)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim weight, height, BMI As Double

        weight = Val(TextBox1.Text)
        height = Val(TextBox2.Text)

        BMI = weight / (height) ^ 2
        TextBox3.Text = BMI

        If BMI < 18 Then
            TextBox4.Text = "You are underweight"
        ElseIf 18 <= BMI And BMI < 26 Then
            TextBox4.Text = "You are normal"
        Else TextBox4.Text = "You are overweight"
        End If

    End Sub

    Friend WithEvents Label5 As Label
End Class
