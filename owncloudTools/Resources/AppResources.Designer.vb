﻿'------------------------------------------------------------------------------
' <auto-generated>
'     Ce code a été généré par un outil.
'     Version du runtime :4.0.30319.34014
'
'     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
'     le code est régénéré.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System


'Cette classe a été générée automatiquement par la classe StronglyTypedResourceBuilder
'à l'aide d'un outil, tel que ResGen ou Visual Studio.
'Pour ajouter ou supprimer un membre, modifiez votre fichier .ResX, puis réexécutez ResGen
'avec l'option /str ou régénérez votre projet VS.
'''<summary>
'''  Une classe de ressource fortement typée destinée, entre autres, à la consultation des chaînes localisées.
'''</summary>
<Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0"),  _
 Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
 Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>  _
Public Class AppResources
    
    Private Shared resourceMan As Global.System.Resources.ResourceManager
    
    Private Shared resourceCulture As Global.System.Globalization.CultureInfo
    
    <Global.System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")>  _
    Friend Sub New()
        MyBase.New
    End Sub
    
    '''<summary>
    '''  Retourne l'instance ResourceManager mise en cache utilisée par cette classe.
    '''</summary>
    <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
    Public Shared ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
        Get
            If Object.ReferenceEquals(resourceMan, Nothing) Then
                Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("owncloudTools.AppResources", GetType(AppResources).Assembly)
                resourceMan = temp
            End If
            Return resourceMan
        End Get
    End Property
    
    '''<summary>
    '''  Remplace la propriété CurrentUICulture du thread actuel pour toutes
    '''  les recherches de ressources à l'aide de cette classe de ressource fortement typée.
    '''</summary>
    <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
    Public Shared Property Culture() As Global.System.Globalization.CultureInfo
        Get
            Return resourceCulture
        End Get
        Set
            resourceCulture = value
        End Set
    End Property
    
    '''<summary>
    '''  Recherche une chaîne localisée semblable à ajouter.
    '''</summary>
    Public Shared ReadOnly Property AppBarButtonText() As String
        Get
            Return ResourceManager.GetString("AppBarButtonText", resourceCulture)
        End Get
    End Property
    
    '''<summary>
    '''  Recherche une chaîne localisée semblable à Élément de menu.
    '''</summary>
    Public Shared ReadOnly Property AppBarMenuItemText() As String
        Get
            Return ResourceManager.GetString("AppBarMenuItemText", resourceCulture)
        End Get
    End Property
    
    '''<summary>
    '''  Recherche une chaîne localisée semblable à webDav Photo.
    '''</summary>
    Public Shared ReadOnly Property ApplicationTitle() As String
        Get
            Return ResourceManager.GetString("ApplicationTitle", resourceCulture)
        End Get
    End Property
    
    '''<summary>
    '''  Recherche une chaîne localisée semblable à Envoyer à nouveau.
    '''</summary>
    Public Shared ReadOnly Property btnSend() As String
        Get
            Return ResourceManager.GetString("btnSend", resourceCulture)
        End Get
    End Property
    
    '''<summary>
    '''  Recherche une chaîne localisée semblable à Appareil photo indisponible.
    '''</summary>
    Public Shared ReadOnly Property CamDetectionKO() As String
        Get
            Return ResourceManager.GetString("CamDetectionKO", resourceCulture)
        End Get
    End Property
    
    '''<summary>
    '''  Recherche une chaîne localisée semblable à Se connecter ....
    '''</summary>
    Public Shared ReadOnly Property mpBtnConnect() As String
        Get
            Return ResourceManager.GetString("mpBtnConnect", resourceCulture)
        End Get
    End Property
    
    '''<summary>
    '''  Recherche une chaîne localisée semblable à Mot de passe.
    '''</summary>
    Public Shared ReadOnly Property mpPassword() As String
        Get
            Return ResourceManager.GetString("mpPassword", resourceCulture)
        End Get
    End Property
    
    '''<summary>
    '''  Recherche une chaîne localisée semblable à Serveur.
    '''</summary>
    Public Shared ReadOnly Property mpServer() As String
        Get
            Return ResourceManager.GetString("mpServer", resourceCulture)
        End Get
    End Property
    
    '''<summary>
    '''  Recherche une chaîne localisée semblable à Paramètres.
    '''</summary>
    Public Shared ReadOnly Property mpTitle() As String
        Get
            Return ResourceManager.GetString("mpTitle", resourceCulture)
        End Get
    End Property
    
    '''<summary>
    '''  Recherche une chaîne localisée semblable à Nom d&apos;utilisateur.
    '''</summary>
    Public Shared ReadOnly Property mpUser() As String
        Get
            Return ResourceManager.GetString("mpUser", resourceCulture)
        End Get
    End Property
    
    '''<summary>
    '''  Recherche une chaîne localisée semblable à Début du transfert.
    '''</summary>
    Public Shared ReadOnly Property picListBeginTrans() As String
        Get
            Return ResourceManager.GetString("picListBeginTrans", resourceCulture)
        End Get
    End Property
    
    '''<summary>
    '''  Recherche une chaîne localisée semblable à Fin du transfert.
    '''</summary>
    Public Shared ReadOnly Property picListEndTrans() As String
        Get
            Return ResourceManager.GetString("picListEndTrans", resourceCulture)
        End Get
    End Property
    
    '''<summary>
    '''  Recherche une chaîne localisée semblable à Transfert en cours de .
    '''</summary>
    Public Shared ReadOnly Property picListFileTrans() As String
        Get
            Return ResourceManager.GetString("picListFileTrans", resourceCulture)
        End Get
    End Property
    
    '''<summary>
    '''  Recherche une chaîne localisée semblable à Tous les fichiers sont sur le serveur.
    '''</summary>
    Public Shared ReadOnly Property picListOK() As String
        Get
            Return ResourceManager.GetString("picListOK", resourceCulture)
        End Get
    End Property
    
    '''<summary>
    '''  Recherche une chaîne localisée semblable à Photo transférée sur le serveur.
    '''</summary>
    Public Shared ReadOnly Property PictureTransfered() As String
        Get
            Return ResourceManager.GetString("PictureTransfered", resourceCulture)
        End Get
    End Property
    
    '''<summary>
    '''  Recherche une chaîne localisée semblable à LeftToRight.
    '''</summary>
    Public Shared ReadOnly Property ResourceFlowDirection() As String
        Get
            Return ResourceManager.GetString("ResourceFlowDirection", resourceCulture)
        End Get
    End Property
    
    '''<summary>
    '''  Recherche une chaîne localisée semblable à fr-FR.
    '''</summary>
    Public Shared ReadOnly Property ResourceLanguage() As String
        Get
            Return ResourceManager.GetString("ResourceLanguage", resourceCulture)
        End Get
    End Property
    
    '''<summary>
    '''  Recherche une chaîne localisée semblable à Serveur injoignable.
    '''</summary>
    Public Shared ReadOnly Property serverUnavaible() As String
        Get
            Return ResourceManager.GetString("serverUnavaible", resourceCulture)
        End Get
    End Property
    
    '''<summary>
    '''  Recherche une chaîne localisée semblable à photos à transférer ....
    '''</summary>
    Public Shared ReadOnly Property todo() As String
        Get
            Return ResourceManager.GetString("todo", resourceCulture)
        End Get
    End Property
    
    '''<summary>
    '''  Recherche une chaîne localisée semblable à TéléversementInstantané.
    '''</summary>
    Public Shared ReadOnly Property uploadFolder() As String
        Get
            Return ResourceManager.GetString("uploadFolder", resourceCulture)
        End Get
    End Property
End Class
