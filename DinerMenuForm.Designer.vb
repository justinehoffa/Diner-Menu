<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DinerMenuForm
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
        Me.Pizza = New System.Windows.Forms.Button()
        Me.Spaghetti = New System.Windows.Forms.Button()
        Me.ChickenParmesan = New System.Windows.Forms.Button()
        Me.Home = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Item2Label = New System.Windows.Forms.Label()
        Me.Item1Label = New System.Windows.Forms.Label()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Pizza
        '
        Me.Pizza.Location = New System.Drawing.Point(311, 274)
        Me.Pizza.Name = "Pizza"
        Me.Pizza.Size = New System.Drawing.Size(193, 101)
        Me.Pizza.TabIndex = 0
        Me.Pizza.Text = "Pizza"
        Me.Pizza.UseVisualStyleBackColor = True
        '
        'Spaghetti
        '
        Me.Spaghetti.Location = New System.Drawing.Point(563, 274)
        Me.Spaghetti.Name = "Spaghetti"
        Me.Spaghetti.Size = New System.Drawing.Size(180, 101)
        Me.Spaghetti.TabIndex = 1
        Me.Spaghetti.Text = "Spaghetti"
        Me.Spaghetti.UseVisualStyleBackColor = True
        '
        'ChickenParmesan
        '
        Me.ChickenParmesan.Location = New System.Drawing.Point(805, 274)
        Me.ChickenParmesan.Name = "ChickenParmesan"
        Me.ChickenParmesan.Size = New System.Drawing.Size(177, 101)
        Me.ChickenParmesan.TabIndex = 2
        Me.ChickenParmesan.Text = "Chicken Parmesan"
        Me.ChickenParmesan.UseVisualStyleBackColor = True
        '
        'Home
        '
        Me.Home.Location = New System.Drawing.Point(440, 425)
        Me.Home.Name = "Home"
        Me.Home.Size = New System.Drawing.Size(185, 105)
        Me.Home.TabIndex = 3
        Me.Home.Text = "Home"
        Me.Home.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button5.Location = New System.Drawing.Point(701, 425)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(187, 105)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "Exit"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Item2Label)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Item1Label)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Pizza)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Home)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Button5)
        Me.SplitContainer1.Panel2.Controls.Add(Me.ChickenParmesan)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Spaghetti)
        Me.SplitContainer1.Panel2.Controls.Add(Me.RichTextBox1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1316, 779)
        Me.SplitContainer1.SplitterDistance = 139
        Me.SplitContainer1.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(558, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(342, 76)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Diner Menu"
        '
        'Item2Label
        '
        Me.Item2Label.Location = New System.Drawing.Point(639, 49)
        Me.Item2Label.Name = "Item2Label"
        Me.Item2Label.Size = New System.Drawing.Size(617, 147)
        Me.Item2Label.TabIndex = 8
        '
        'Item1Label
        '
        Me.Item1Label.Location = New System.Drawing.Point(96, 49)
        Me.Item1Label.Name = "Item1Label"
        Me.Item1Label.Size = New System.Drawing.Size(469, 147)
        Me.Item1Label.TabIndex = 7
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBox1.Location = New System.Drawing.Point(0, 0)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(1316, 636)
        Me.RichTextBox1.TabIndex = 5
        Me.RichTextBox1.Text = ""
        '
        'DinerMenuForm
        '
        Me.AcceptButton = Me.Home
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Button5
        Me.ClientSize = New System.Drawing.Size(1316, 779)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "DinerMenuForm"
        Me.Text = "Form1"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Pizza As Button
    Friend WithEvents Spaghetti As Button
    Friend WithEvents ChickenParmesan As Button
    Friend WithEvents Home As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents Label1 As Label
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Item2Label As Label
    Friend WithEvents Item1Label As Label
End Class
