﻿#ExternalChecksum("D:\DEV\TFS\Win8\owncloud\owncloudTools\owncloudTools\pic.xaml","{406ea660-64cf-4c82-b6f0-42d48172a799}","779310C491EE99D6054D339B5ED13F43")
'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.34014
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports Microsoft.Phone.Controls
Imports System
Imports System.Windows
Imports System.Windows.Automation
Imports System.Windows.Automation.Peers
Imports System.Windows.Automation.Provider
Imports System.Windows.Controls
Imports System.Windows.Controls.Primitives
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Ink
Imports System.Windows.Input
Imports System.Windows.Interop
Imports System.Windows.Markup
Imports System.Windows.Media
Imports System.Windows.Media.Animation
Imports System.Windows.Media.Imaging
Imports System.Windows.Resources
Imports System.Windows.Shapes
Imports System.Windows.Threading



<Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>  _
Partial Public Class pic
    Inherits Microsoft.Phone.Controls.PhoneApplicationPage
    
    Friend WithEvents LayoutRoot As System.Windows.Controls.Grid
    
    Friend WithEvents imgNetOK As System.Windows.Controls.Image
    
    Friend WithEvents imgNetKO As System.Windows.Controls.Image
    
    Friend WithEvents imgNetPending As System.Windows.Controls.Image
    
    Friend WithEvents imgSettings As System.Windows.Controls.Image
    
    Friend WithEvents imgList As System.Windows.Controls.Image
    
    Friend WithEvents imgFlashAuto As System.Windows.Controls.Image
    
    Friend WithEvents imgFlashOFF As System.Windows.Controls.Image
    
    Friend WithEvents imgFlashON As System.Windows.Controls.Image
    
    Friend WithEvents viewfinderCanvas As System.Windows.Controls.Canvas
    
    Friend WithEvents viewfinderBrush As System.Windows.Media.VideoBrush
    
    Friend WithEvents viewfinderTransform As System.Windows.Media.CompositeTransform
    
    Friend WithEvents imgTakePic As System.Windows.Controls.Image
    
    Friend WithEvents imgTakePic2 As System.Windows.Controls.Image
    
    Friend WithEvents imgTakePic3 As System.Windows.Controls.Image
    
    Private _contentLoaded As Boolean
    
    '''<summary>
    '''InitializeComponent
    '''</summary>
    <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Public Sub InitializeComponent()
        If _contentLoaded Then
            Return
        End If
        _contentLoaded = true
        System.Windows.Application.LoadComponent(Me, New System.Uri("/owncloudTools;component/pic.xaml", System.UriKind.Relative))
        Me.LayoutRoot = CType(Me.FindName("LayoutRoot"),System.Windows.Controls.Grid)
        Me.imgNetOK = CType(Me.FindName("imgNetOK"),System.Windows.Controls.Image)
        Me.imgNetKO = CType(Me.FindName("imgNetKO"),System.Windows.Controls.Image)
        Me.imgNetPending = CType(Me.FindName("imgNetPending"),System.Windows.Controls.Image)
        Me.imgSettings = CType(Me.FindName("imgSettings"),System.Windows.Controls.Image)
        Me.imgList = CType(Me.FindName("imgList"),System.Windows.Controls.Image)
        Me.imgFlashAuto = CType(Me.FindName("imgFlashAuto"),System.Windows.Controls.Image)
        Me.imgFlashOFF = CType(Me.FindName("imgFlashOFF"),System.Windows.Controls.Image)
        Me.imgFlashON = CType(Me.FindName("imgFlashON"),System.Windows.Controls.Image)
        Me.viewfinderCanvas = CType(Me.FindName("viewfinderCanvas"),System.Windows.Controls.Canvas)
        Me.viewfinderBrush = CType(Me.FindName("viewfinderBrush"),System.Windows.Media.VideoBrush)
        Me.viewfinderTransform = CType(Me.FindName("viewfinderTransform"),System.Windows.Media.CompositeTransform)
        Me.imgTakePic = CType(Me.FindName("imgTakePic"),System.Windows.Controls.Image)
        Me.imgTakePic2 = CType(Me.FindName("imgTakePic2"),System.Windows.Controls.Image)
        Me.imgTakePic3 = CType(Me.FindName("imgTakePic3"),System.Windows.Controls.Image)
    End Sub
End Class
