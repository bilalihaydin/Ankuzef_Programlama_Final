<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Ankuzef_Programlama_Final.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lbl_HspNo" runat="server" Text="Hesap No"></asp:Label>
            <asp:TextBox ID="txt_hspNo" runat="server" style="margin-left: 118px"></asp:TextBox>
        </div>
        <p>
            <asp:Label ID="lbl_HspAd" runat="server" Text="Hesap Adı"></asp:Label>
            <asp:TextBox ID="txt_hspAd" runat="server" style="margin-left: 118px"></asp:TextBox>
        </p>
        <asp:Label ID="lbl_borc" runat="server" Text="Borç"></asp:Label>
        <asp:TextBox ID="txt_borc" runat="server" style="margin-left: 153px"></asp:TextBox>
        <p>
            <asp:Label ID="lbl_Alacak" runat="server" Text="Alacak"></asp:Label>
            <asp:TextBox ID="txt_alacak" runat="server" style="margin-left: 141px"></asp:TextBox>
        </p>
        <asp:Label ID="lbl_aciklama" runat="server" Text="Açıklama"></asp:Label>
        <p>
            <asp:TextBox ID="txt_aciklama" runat="server" Height="53px" style="margin-left: 0px" Width="213px"></asp:TextBox>
            <asp:Label ID="Label1" runat="server" Text="Sonuç : "></asp:Label>
            <asp:Label ID="lbl_snc" runat="server"></asp:Label>
        </p>
        <asp:Button ID="btn_Ekle" runat="server" Height="39px" OnClick="btn_Ekle_Click" Text="Ekle" Width="110px" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btn_Guncelle" runat="server" Height="39px" OnClick="btn_Guncelle_Click" Text="Güncelle" Width="110px" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btn_Sil" runat="server" Height="39px" OnClick="btn_Sil_Click" Text="Sil" Width="110px" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btn_lst" runat="server" Height="37px" OnClick="btn_lst_Click" Text="Listele" Width="110px" />
        <asp:GridView ID="GridView1" runat="server" Height="158px" style="margin-top: 24px" Width="721px">
        </asp:GridView>
    </form>
</body>
</html>
