### Validation Group Property in Validation control:

The validation groups help you to group the controls in a single page and you can have separate submit buttons for each group, so that you can submit each group individually. Each group can have separate validation controls.

For Example:

 <asp:TextBox ID="txtOne" runat="server"></asp:TextBox>

<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtOne" ErrorMessage="Required" ValidationGroup="One" ForeColor="Red" SetFocusOnError="True">*</asp:RequiredFieldValidator>



<asp:TextBox ID="txtTwo" runat="server"></asp:TextBox>
<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtTwo" ErrorMessage="Required" ValidationGroup="One" ForeColor="Red" SetFocusOnError="True">*</asp:RequiredFieldValidator>



 

<asp:TextBox ID="txtThree" runat="server"></asp:TextBox>
<asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtThree" ErrorMessage="Required" ValidationGroup="Two" ForeColor="Red" SetFocusOnError="True">*</asp:RequiredFieldValidator>



<asp:TextBox ID="txtFour" runat="server"></asp:TextBox>
<asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtFour" ErrorMessage="Required" ValidationGroup="Two" ForeColor="Red" SetFocusOnError="True">*</asp:RequiredFieldValidator>



 <asp:Button ID="Button1" runat="server" Text="Create" ValidationGroup="One" OnClick="Button1_Click"/> 

 

 <asp:Button ID="Button2" runat="server" Text="Create" ValidationGroup="Two" OnClick="Button2_Click" style="margin-left: 13px"/>

