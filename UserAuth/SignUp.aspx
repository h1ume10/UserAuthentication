<%@ Page Title="" Language="C#" MasterPageFile="~/Authentication.Master" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="UserAuth.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container mt-5">
        <div class="row justify-content-center">
            <div class="col-md-6">
                <div class="my-2">
                    <h2>Sign Up</h2>
                </div>
                <div>
                    <p>Welcome! Please sign up to continue.</p>
                </div>
                <div class="shadow-sm p-3 mt-3 mb-5 bg-body-tertiary rounded">
                    <div class="row">
                        <div class="col-md-6">
                            <div class="my-2">
                                <label>First Name</label>
                            </div>
                            <div>
                                <asp:TextBox ID="txtFirstName" runat="server" CssClass="form-control" PlaceHolder="First Name"></asp:TextBox>
                            </div>
                        </div>
                        <div class="col-md-6">
                            <div class="my-2">
                                <label>Last Name</label>
                            </div>
                            <div>
                                <asp:TextBox ID="txtLastName" runat="server" CssClass="form-control" PlaceHolder="Last Name"></asp:TextBox>
                            </div>
                        </div>
                    </div>
                    <div>
                        <div class="my-2">
                            <label>Email Address</label>
                        </div>
                        <div>
                            <asp:TextBox ID="txtSignUpEmail" runat="server" CssClass="form-control" PlaceHolder="Email Address" TextMode="Email"></asp:TextBox>
                        </div>
                        <div class="my-2">
                            <label>Password</label>
                        </div>
                        <div>
                            <asp:TextBox ID="txtSignUpPassword" runat="server" CssClass="form-control" PlaceHolder="Password" TextMode="Password"></asp:TextBox>
                        </div>
                        <div class="my-2">
                            <label>Confirm Password</label>
                        </div>
                        <div>
                            <asp:TextBox ID="txtConfirmPassword" runat="server" CssClass="form-control" PlaceHolder="Confirm Password" TextMode="Password"></asp:TextBox>
                        </div>
                        <div class="my-4">
                            <asp:Button ID="btnSignUp" runat="server" Text="Sign Up" CssClass="btn btn-outline-primary w-25" OnClick="btnSignUp_Click" />
                        </div>
                        <div>
                            <p>Already have an account? <a href="SignIn.aspx">Sign In</a> instead.</p>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
