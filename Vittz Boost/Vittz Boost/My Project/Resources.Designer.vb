﻿'------------------------------------------------------------------------------
' <auto-generated>
'     O código foi gerado por uma ferramenta.
'     Versão de Tempo de Execução:4.0.30319.42000
'
'     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
'     o código for gerado novamente.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    
    'Essa classe foi gerada automaticamente pela classe StronglyTypedResourceBuilder
    'através de uma ferramenta como ResGen ou Visual Studio.
    'Para adicionar ou remover um associado, edite o arquivo .ResX e execute ResGen novamente
    'com a opção /str, ou recrie o projeto do VS.
    '''<summary>
    '''  Uma classe de recurso de tipo de alta segurança, para pesquisar cadeias de caracteres localizadas etc.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.Microsoft.VisualBasic.HideModuleNameAttribute()>  _
    Friend Module Resources
        
        Private resourceMan As Global.System.Resources.ResourceManager
        
        Private resourceCulture As Global.System.Globalization.CultureInfo
        
        '''<summary>
        '''  Retorna a instância de ResourceManager armazenada em cache usada por essa classe.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("Vittz_Boost.Resources", GetType(Resources).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  Substitui a propriedade CurrentUICulture do thread atual para todas as
        '''  pesquisas de recursos que usam essa classe de recurso de tipo de alta segurança.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  Consulta um recurso localizado do tipo System.Byte[].
        '''</summary>
        Friend ReadOnly Property _10AppsManager() As Byte()
            Get
                Dim obj As Object = ResourceManager.GetObject("_10AppsManager", resourceCulture)
                Return CType(obj,Byte())
            End Get
        End Property
        
        '''<summary>
        '''  Consulta uma cadeia de caracteres localizada semelhante a color b
        '''/s /f /q c:\windows\temp\*.*
        '''rd /s /q c:\windows\temp
        '''md c:\windows\temp
        '''del /s /f /q C:\WINDOWS\Prefetch
        '''del /s /f /q %temp%\*.*
        '''rd /s /q %temp%
        '''md %temp%
        '''deltree /y c:\windows\tempor~1
        '''deltree /y c:\windows\temp
        '''deltree /y c:\windows\tmp
        '''deltree /y c:\windows\ff*.tmp
        '''deltree /y c:\windows\history
        '''deltree /y c:\windows\cookies
        '''deltree /y c:\windows\recent
        '''deltree /y c:\windows\spool\printers
        '''del c:\WIN386.SWP
        '''cls 
        '''FOR /F &quot;tokens=1, 2 * &quot; %%V IN (&apos;bcdedit&apos;) DO SET adminTest=%%V
        '''IF (%adminTest%)==(Ac [o restante da cadeia de caracteres foi truncado]&quot;;.
        '''</summary>
        Friend ReadOnly Property CacheCleaner() As String
            Get
                Return ResourceManager.GetString("CacheCleaner", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Consulta um recurso localizado do tipo System.Byte[].
        '''</summary>
        Friend ReadOnly Property DefenderControl() As Byte()
            Get
                Dim obj As Object = ResourceManager.GetObject("DefenderControl", resourceCulture)
                Return CType(obj,Byte())
            End Get
        End Property
        
        '''<summary>
        '''  Consulta uma cadeia de caracteres localizada semelhante a Windows Registry Editor Version 5.00      Reg By youtube.com/panjno
        '''
        '''
        '''[HKEY_CURRENT_USER\System\GameConfigStore]
        '''
        '''&quot;GameDVR_Enabled&quot;=dword:00000000
        '''.
        '''</summary>
        Friend ReadOnly Property Disable_DVR_1() As String
            Get
                Return ResourceManager.GetString("Disable_DVR_1", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Consulta uma cadeia de caracteres localizada semelhante a Windows Registry Editor Version 5.00       Reg By youtube.com/panjno
        '''
        '''
        '''[HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\PolicyManager\default\ApplicationManagement\AllowGameDVR]
        '''
        '''&quot;value&quot;=dword:00000000
        '''
        '''.
        '''</summary>
        Friend ReadOnly Property Disable_DVR_2() As String
            Get
                Return ResourceManager.GetString("Disable_DVR_2", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Consulta uma cadeia de caracteres localizada semelhante a Windows Registry Editor Version 5.00
        '''
        '''
        '''[HKEY_CURRENT_USER\System\GameConfigStore]
        '''
        '''&quot;GameDVR_FSEBehaviorMode&quot;=dword:00000002
        '''
        '''&quot;GameDVR_HonorUserFSEBehaviorMode&quot;=dword:00000001
        '''
        '''&quot;GameDVR_FSEBehavior&quot;=dword:00000002
        '''
        '''&quot;GameDVR_DXGIHonorFSEWindowsCompatible&quot;=dword:00000001.
        '''</summary>
        Friend ReadOnly Property fullscreenfix() As String
            Get
                Return ResourceManager.GetString("fullscreenfix", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Consulta uma cadeia de caracteres localizada semelhante a Windows Registry Editor Version 5.00                                                                                                                                     https://www.youtube.com/adamx17
        ''' 
        '''[HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Multimedia\SystemProfile]
        '''&quot;NetworkThrottlingIndex&quot;=dword:ffffffff
        '''&quot;SystemResponsiveness&quot;=dword:00000000
        '''
        '''[HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Power\PowerThrottling]
        '''&quot;PowerThrottlingOff&quot;=dword:00000001
        '''
        '''[HKEY_LOCAL_MACHI [o restante da cadeia de caracteres foi truncado]&quot;;.
        '''</summary>
        Friend ReadOnly Property RegistryOptimizations() As String
            Get
                Return ResourceManager.GetString("RegistryOptimizations", resourceCulture)
            End Get
        End Property
    End Module
End Namespace
