<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.nameBox = New System.Windows.Forms.TextBox()
        Me.sellingPriceBox = New System.Windows.Forms.TextBox()
        Me.costPriceBox = New System.Windows.Forms.TextBox()
        Me.calculateBtn = New System.Windows.Forms.Button()
        Me.clearBtn = New System.Windows.Forms.Button()
        Me.printBtn = New System.Windows.Forms.Button()
        Me.commission = New System.Windows.Forms.Label()
        Me.commissionBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 32)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sales person's name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 102)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Selling price of vehicle:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(31, 176)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Cost value of vehicle"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(28, 222)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Commission rate: 20%"
        '
        'nameBox
        '
        Me.nameBox.Location = New System.Drawing.Point(183, 28)
        Me.nameBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.nameBox.Name = "nameBox"
        Me.nameBox.Size = New System.Drawing.Size(76, 20)
        Me.nameBox.TabIndex = 4
        '
        'sellingPriceBox
        '
        Me.sellingPriceBox.Location = New System.Drawing.Point(183, 102)
        Me.sellingPriceBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.sellingPriceBox.Name = "sellingPriceBox"
        Me.sellingPriceBox.Size = New System.Drawing.Size(76, 20)
        Me.sellingPriceBox.TabIndex = 5
        '
        'costPriceBox
        '
        Me.costPriceBox.Location = New System.Drawing.Point(183, 172)
        Me.costPriceBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.costPriceBox.Name = "costPriceBox"
        Me.costPriceBox.Size = New System.Drawing.Size(76, 20)
        Me.costPriceBox.TabIndex = 6
        '
        'calculateBtn
        '
        Me.calculateBtn.Location = New System.Drawing.Point(78, 303)
        Me.calculateBtn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.calculateBtn.Name = "calculateBtn"
        Me.calculateBtn.Size = New System.Drawing.Size(56, 19)
        Me.calculateBtn.TabIndex = 7
        Me.calculateBtn.Text = "Calculate"
        Me.calculateBtn.UseVisualStyleBackColor = True
        '
        'clearBtn
        '
        Me.clearBtn.Location = New System.Drawing.Point(255, 303)
        Me.clearBtn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.clearBtn.Name = "clearBtn"
        Me.clearBtn.Size = New System.Drawing.Size(56, 19)
        Me.clearBtn.TabIndex = 8
        Me.clearBtn.Text = "Clear"
        Me.clearBtn.UseVisualStyleBackColor = True
        '
        'printBtn
        '
        Me.printBtn.Location = New System.Drawing.Point(476, 303)
        Me.printBtn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.printBtn.Name = "printBtn"
        Me.printBtn.Size = New System.Drawing.Size(56, 19)
        Me.printBtn.TabIndex = 9
        Me.printBtn.Text = "Print"
        Me.printBtn.UseVisualStyleBackColor = True
        '
        'commission
        '
        Me.commission.AutoSize = True
        Me.commission.Location = New System.Drawing.Point(28, 262)
        Me.commission.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.commission.Name = "commission"
        Me.commission.Size = New System.Drawing.Size(65, 13)
        Me.commission.TabIndex = 10
        Me.commission.Text = "Commission:"
        '
        'commissionBox
        '
        Me.commissionBox.Location = New System.Drawing.Point(183, 258)
        Me.commissionBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.commissionBox.Name = "commissionBox"
        Me.commissionBox.Size = New System.Drawing.Size(76, 20)
        Me.commissionBox.TabIndex = 11
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(476, 161)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(56, 19)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Close"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 366)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.commissionBox)
        Me.Controls.Add(Me.commission)
        Me.Controls.Add(Me.printBtn)
        Me.Controls.Add(Me.clearBtn)
        Me.Controls.Add(Me.calculateBtn)
        Me.Controls.Add(Me.costPriceBox)
        Me.Controls.Add(Me.sellingPriceBox)
        Me.Controls.Add(Me.nameBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents nameBox As TextBox
    Friend WithEvents sellingPriceBox As TextBox
    Friend WithEvents costPriceBox As TextBox
    Friend WithEvents calculateBtn As Button
    Friend WithEvents clearBtn As Button
    Friend WithEvents printBtn As Button
    Friend WithEvents commission As Label
    Friend WithEvents commissionBox As TextBox
    Friend WithEvents Button1 As Button
End Class
