﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        btnTotal = New Button()
        txtPrice = New TextBox()
        txtQuantity = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        txtNameOfCustomer = New TextBox()
        Customer = New Label()
        SuspendLayout()
        ' 
        ' btnTotal
        ' 
        btnTotal.Location = New Point(303, 257)
        btnTotal.Name = "btnTotal"
        btnTotal.Size = New Size(197, 34)
        btnTotal.TabIndex = 0
        btnTotal.Text = "Total for Customer"
        btnTotal.UseVisualStyleBackColor = True
        ' 
        ' txtPrice
        ' 
        txtPrice.Location = New Point(380, 76)
        txtPrice.Name = "txtPrice"
        txtPrice.Size = New Size(150, 31)
        txtPrice.TabIndex = 1
        ' 
        ' txtQuantity
        ' 
        txtQuantity.Location = New Point(380, 135)
        txtQuantity.Name = "txtQuantity"
        txtQuantity.Size = New Size(150, 31)
        txtQuantity.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(189, 141)
        Label1.Name = "Label1"
        Label1.Size = New Size(151, 25)
        Label1.TabIndex = 2
        Label1.Text = "Quantity of Items"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(189, 79)
        Label2.Name = "Label2"
        Label2.Size = New Size(119, 25)
        Label2.TabIndex = 2
        Label2.Text = "Price Per Item"
        ' 
        ' txtNameOfCustomer
        ' 
        txtNameOfCustomer.Location = New Point(380, 202)
        txtNameOfCustomer.Name = "txtNameOfCustomer"
        txtNameOfCustomer.Size = New Size(150, 31)
        txtNameOfCustomer.TabIndex = 1
        ' 
        ' Customer
        ' 
        Customer.AutoSize = True
        Customer.Location = New Point(189, 208)
        Customer.Name = "Customer"
        Customer.Size = New Size(163, 25)
        Customer.TabIndex = 2
        Customer.Text = "Name of Customer"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label2)
        Controls.Add(Customer)
        Controls.Add(Label1)
        Controls.Add(txtNameOfCustomer)
        Controls.Add(txtQuantity)
        Controls.Add(txtPrice)
        Controls.Add(btnTotal)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnTotal As Button
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNameOfCustomer As TextBox
    Friend WithEvents Customer As Label
End Class
