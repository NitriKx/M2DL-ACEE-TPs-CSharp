<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Rechercher une recette</title>
</head>
<body>
    <h2>Rechercher une recette</h2>
    < ID="rechercheRecetteParNomForm" runat="server">
    <div>
        <asp:Label runat="server" >Par nom</asp:Label>
        <asp:TextBox ID="nomRecette" ></asp:TextBox>
        <asp:Button UseSubmitBehavior="true" />
     </div>
    </>
</body>
</html>
