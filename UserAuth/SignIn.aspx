<%@ Page Title="" Language="C#" MasterPageFile="~/Authentication.Master" AutoEventWireup="true" CodeBehind="SignIn.aspx.cs" Inherits="UserAuth.WebForm2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container mt-5">
        <div class="row justify-content-center">
            <div class="col-md-6">
                <div class="my-2">
                    <h2>Sign In</h2>
                </div>
                <div>
                    <p>Welcome Back! Sign in with your details below to continue.</p>
                </div>
                <div class="shadow-sm p-3 mt-3 mb-5 bg-body-tertiary rounded">
                    <div class="my-2">
                        <label>Email Address</label>
                    </div>
                    <div>
                        <asp:TextBox ID="txtSignInEmail" runat="server" CssClass="form-control" PlaceHolder="Email Address" TextMode="Email"></asp:TextBox>
                    </div>
                    <div class="my-2">
                        <label>Password</label>
                    </div>
                    <div>
                        <asp:TextBox ID="txtSignInPassword" runat="server" CssClass="form-control" PlaceHolder="Password" TextMode="Password"></asp:TextBox>
                    </div>
                    <div class="my-4">
                        <asp:Button ID="btnSignIn" runat="server" Text="Sign In" CssClass="btn btn-outline-primary w-25" OnClick="btnSignIn_Click" />
                    </div>
                    <div>
                        <p>Don't have an account yet? <a href="SignUp.aspx">Sign Up here</a></p>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
