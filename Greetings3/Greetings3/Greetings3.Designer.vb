<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Greetings3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Greetings3))
        Me.btnClick = New System.Windows.Forms.Button()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lstOut = New System.Windows.Forms.ListBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.picGreeting = New System.Windows.Forms.PictureBox()
        CType(Me.picGreeting, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnClick
        '
        Me.btnClick.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnClick.Font = New System.Drawing.Font("Book Antiqua", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClick.ForeColor = System.Drawing.Color.White
        Me.btnClick.Location = New System.Drawing.Point(63, 201)
        Me.btnClick.Name = "btnClick"
        Me.btnClick.Size = New System.Drawing.Size(140, 48)
        Me.btnClick.TabIndex = 0
        Me.btnClick.Text = "Click Me!"
        Me.btnClick.UseVisualStyleBackColor = False
        '
        'txtName
        '
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtName.Font = New System.Drawing.Font("Book Antiqua", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(63, 145)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(191, 33)
        Me.txtName.TabIndex = 1
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Book Antiqua", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Location = New System.Drawing.Point(58, 28)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(252, 32)
        Me.lblHeading.TabIndex = 2
        Me.lblHeading.Text = "Greetings Program"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Book Antiqua", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(58, 98)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(180, 26)
        Me.lblName.TabIndex = 3
        Me.lblName.Text = "Enter Your Name "
        '
        'lstOut
        '
        Me.lstOut.Font = New System.Drawing.Font("Book Antiqua", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstOut.FormattingEnabled = True
        Me.lstOut.ItemHeight = 26
        Me.lstOut.Location = New System.Drawing.Point(63, 272)
        Me.lstOut.Name = "lstOut"
        Me.lstOut.Size = New System.Drawing.Size(273, 134)
        Me.lstOut.TabIndex = 4
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.LightGray
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(64, 433)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(77, 31)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.LightGray
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(188, 433)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(84, 31)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'picGreeting
        '
        Me.picGreeting.Image = CType(resources.GetObject("picGreeting.Image"), System.Drawing.Image)
        Me.picGreeting.Location = New System.Drawing.Point(458, 145)
        Me.picGreeting.Name = "picGreeting"
        Me.picGreeting.Size = New System.Drawing.Size(323, 219)
        Me.picGreeting.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picGreeting.TabIndex = 7
        Me.picGreeting.TabStop = False
        '
        'Greetings3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(818, 556)
        Me.Controls.Add(Me.picGreeting)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lstOut)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblHeading)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.btnClick)
        Me.Name = "Greetings3"
        Me.Text = "Greetings3"
        CType(Me.picGreeting, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnClick As Button
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblHeading As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lstOut As ListBox
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents picGreeting As PictureBox
End Class
