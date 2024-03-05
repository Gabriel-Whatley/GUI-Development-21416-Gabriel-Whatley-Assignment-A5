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
        rdioSuperhero = New RadioButton()
        rdioAutographs = New RadioButton()
        rdioConvention = New RadioButton()
        Label3 = New Label()
        lblOutput = New Label()
        Label5 = New Label()
        textBxInput = New TextBox()
        btnCalculate = New Button()
        btnClear = New Button()
        PictureBox2 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.comic
        PictureBox1.Location = New Point(12, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(576, 215)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Comic Sans MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        Label1.Location = New Point(148, 249)
        Label1.Name = "Label1"
        Label1.Size = New Size(316, 30)
        Label1.TabIndex = 1
        Label1.Text = "Comic Convention Registration"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Cyan
        Label2.Font = New Font("Comic Sans MS", 13F, FontStyle.Bold)
        Label2.ForeColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        Label2.Location = New Point(125, 339)
        Label2.Name = "Label2"
        Label2.Size = New Size(185, 25)
        Label2.TabIndex = 2
        Label2.Text = "Select Badge Type:"
        ' 
        ' rdioSuperhero
        ' 
        rdioSuperhero.AutoSize = True
        rdioSuperhero.BackColor = Color.Cyan
        rdioSuperhero.Font = New Font("Comic Sans MS", 15.75F, FontStyle.Bold)
        rdioSuperhero.ForeColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        rdioSuperhero.Location = New Point(133, 367)
        rdioSuperhero.Name = "rdioSuperhero"
        rdioSuperhero.Size = New Size(391, 34)
        rdioSuperhero.TabIndex = 3
        rdioSuperhero.TabStop = True
        rdioSuperhero.Text = "Convention + Superhero Experience"
        rdioSuperhero.UseVisualStyleBackColor = False
        ' 
        ' rdioAutographs
        ' 
        rdioAutographs.AutoSize = True
        rdioAutographs.BackColor = Color.Cyan
        rdioAutographs.Font = New Font("Comic Sans MS", 15.75F, FontStyle.Bold)
        rdioAutographs.ForeColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        rdioAutographs.Location = New Point(133, 398)
        rdioAutographs.Name = "rdioAutographs"
        rdioAutographs.Size = New Size(281, 34)
        rdioAutographs.TabIndex = 4
        rdioAutographs.TabStop = True
        rdioAutographs.Text = "Convention + Autographs"
        rdioAutographs.UseVisualStyleBackColor = False
        ' 
        ' rdioConvention
        ' 
        rdioConvention.AutoSize = True
        rdioConvention.BackColor = Color.Cyan
        rdioConvention.Font = New Font("Comic Sans MS", 15.75F, FontStyle.Bold)
        rdioConvention.ForeColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        rdioConvention.Location = New Point(133, 428)
        rdioConvention.Name = "rdioConvention"
        rdioConvention.Size = New Size(137, 34)
        rdioConvention.TabIndex = 5
        rdioConvention.TabStop = True
        rdioConvention.Text = "Convention"
        rdioConvention.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Comic Sans MS", 15.75F, FontStyle.Bold)
        Label3.ForeColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        Label3.Location = New Point(143, 465)
        Label3.Name = "Label3"
        Label3.Size = New Size(197, 30)
        Label3.TabIndex = 6
        Label3.Text = "Registration Cost:"
        ' 
        ' lblOutput
        ' 
        lblOutput.AutoSize = True
        lblOutput.Font = New Font("Comic Sans MS", 15.75F, FontStyle.Bold)
        lblOutput.ForeColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        lblOutput.Location = New Point(346, 465)
        lblOutput.Name = "lblOutput"
        lblOutput.Size = New Size(0, 30)
        lblOutput.TabIndex = 7
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        Label5.Location = New Point(213, 301)
        Label5.Name = "Label5"
        Label5.Size = New Size(101, 23)
        Label5.TabIndex = 8
        Label5.Text = "Group Size:"
        ' 
        ' textBxInput
        ' 
        textBxInput.Font = New Font("Comic Sans MS", 12F, FontStyle.Bold)
        textBxInput.ForeColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        textBxInput.Location = New Point(320, 298)
        textBxInput.Name = "textBxInput"
        textBxInput.Size = New Size(61, 30)
        textBxInput.TabIndex = 9
        textBxInput.TextAlign = HorizontalAlignment.Center
        ' 
        ' btnCalculate
        ' 
        btnCalculate.BackColor = Color.Cyan
        btnCalculate.Font = New Font("Comic Sans MS", 12F, FontStyle.Bold)
        btnCalculate.Location = New Point(153, 512)
        btnCalculate.Name = "btnCalculate"
        btnCalculate.Size = New Size(128, 38)
        btnCalculate.TabIndex = 10
        btnCalculate.Text = "Calculate"
        btnCalculate.UseVisualStyleBackColor = False
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = Color.Cyan
        btnClear.Font = New Font("Comic Sans MS", 12F, FontStyle.Bold)
        btnClear.Location = New Point(320, 512)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(128, 38)
        btnClear.TabIndex = 11
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Cyan
        PictureBox2.Location = New Point(120, 334)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(410, 130)
        PictureBox2.TabIndex = 12
        PictureBox2.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(600, 562)
        Controls.Add(btnClear)
        Controls.Add(btnCalculate)
        Controls.Add(textBxInput)
        Controls.Add(Label5)
        Controls.Add(lblOutput)
        Controls.Add(Label3)
        Controls.Add(rdioConvention)
        Controls.Add(rdioAutographs)
        Controls.Add(rdioSuperhero)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Controls.Add(PictureBox2)
        Name = "Form1"
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents rdioSuperhero As RadioButton
    Friend WithEvents rdioAutographs As RadioButton
    Friend WithEvents rdioConvention As RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents lblOutput As Label
    Private WithEvents Label5 As Label
    Friend WithEvents textBxInput As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents PictureBox2 As PictureBox

End Class
