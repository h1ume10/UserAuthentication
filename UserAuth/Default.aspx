<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="UserAuth.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <!-- BOOSTRAP CSS -->
    <link href="Content/bootstrap.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container mt-5">
            <div class="row justify-content-center">
                <div class="col-md-8">
                    <div>
                        <h2>Welcome</h2>
                    </div>
                    <div class="mt-5">
                        <asp:Button ID="btnSignOut" runat="server" Text="Sign Out" CssClass="btn btn-outline-danger w-25" OnClick="btnSignOut_Click" />
                    </div>
                </div>
            </div>
        </div>
    </form>
    <!-- BOOTSTRAP JS -->
    <script src="Scripts/bootstrap.js"></script>
</body>
</html>
