﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class chooseForm
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnAdmin = New System.Windows.Forms.Button()
        Me.btnEmpList = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnAdmin
        '
        Me.btnAdmin.Location = New System.Drawing.Point(48, 119)
        Me.btnAdmin.Name = "btnAdmin"
        Me.btnAdmin.Size = New System.Drawing.Size(184, 117)
        Me.btnAdmin.TabIndex = 0
        Me.btnAdmin.Text = "管理メニュー"
        Me.btnAdmin.UseVisualStyleBackColor = True
        '
        'btnEmpList
        '
        Me.btnEmpList.Location = New System.Drawing.Point(287, 119)
        Me.btnEmpList.Name = "btnEmpList"
        Me.btnEmpList.Size = New System.Drawing.Size(184, 117)
        Me.btnEmpList.TabIndex = 1
        Me.btnEmpList.Text = "勤務表"
        Me.btnEmpList.UseVisualStyleBackColor = True
        '
        'chooseForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(532, 382)
        Me.Controls.Add(Me.btnEmpList)
        Me.Controls.Add(Me.btnAdmin)
        Me.Name = "chooseForm"
        Me.Text = "chooseForm"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnAdmin As System.Windows.Forms.Button
    Friend WithEvents btnEmpList As System.Windows.Forms.Button
End Class
