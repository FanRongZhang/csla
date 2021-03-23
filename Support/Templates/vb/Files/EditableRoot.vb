<Serializable()>
Public Class EditableRoot
  Inherits BusinessBase(Of EditableRoot)

  Public Shared ReadOnly IdProperty As PropertyInfo(Of Integer) = RegisterProperty(Of Integer)(NameOf(Id))
  Public Property Id() As Integer
    Get
      Return GetProperty(IdProperty)
    End Get
    Set(ByVal value As Integer)
      SetProperty(IdProperty, value)
    End Set
  End Property

  Public Shared ReadOnly NameProperty As PropertyInfo(Of String) = RegisterProperty(Of String)(NameOf(Name))
  Public Property Name() As String
    Get
      Return GetProperty(NameProperty)
    End Get
    Set(ByVal value As String)
      SetProperty(NameProperty, value)
    End Set
  End Property

  Protected Overrides Sub AddBusinessRules()
    'call base class implementation to add data annotation rules to BusinessRules 
    MyBase.AddBusinessRules()

    ' TODO: add validation rules
    'BusinessRules.AddRule(New MyRule, IdProperty)

  End Sub

  Public Shared Sub AddObjectAuthorizationRules()
    'TODO: add authorization rules
    'BusinessRules.AddRule(...)
  End Sub

  <Create>
  <RunLocal()>
  Private Sub Create()
    ' TODO: load default values
    ' omit this override if you have no defaults to set
    BusinessRules.CheckRules()
  End Sub

  <Fetch>
  Private Sub Fetch(ByVal id As Integer)
    ' load values
  End Sub

  <Insert>
  <Transactional(TransactionalTypes.TransactionScope)>
  Private Sub Insert()
    ' TODO: insert values
  End Sub

  <Update>
  <Transactional(TransactionalTypes.TransactionScope)>
  Private Sub Update()
    ' TODO: update values
  End Sub

  <DeleteSelf>
  <Transactional(TransactionalTypes.TransactionScope)>
  Private Sub DeleteSelf()
    Delete(Id)
  End Sub

  <Delete>
  Private Shadows Sub Delete(ByVal id As Integer)
    ' TODO: delete values
  End Sub

End Class
