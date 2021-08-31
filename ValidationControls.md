# ASP.NET Validation Controls

Whenever we design a form where we take input from user there may be a chance that we may not get correct information. So we can go for Validation controls in order to put some validations on the client side.

- Validation controls validates the user input data to ensure that useless, unauthenticated, or contradictory data don't get stored.

  

**Validation Controls are:**

1. ######  Required Field Validator

2. ###### Range Validator

3. ###### Compare Validator

4. ###### Regular Expression

5. ###### Custom Validator

6. ###### Validation Summary <br>


-  Required Field Validator: Required Field Validator control is used to make the input field a required field in the application. The control raises an error if the input value is not entered by the user.<br>
 
   <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="Text_user" Display="Dynamic" ErrorMessage="User id is mandatory" ForeColor="Red"        SetFocusOnError="True">*</asp:RequiredFieldValidator>  

- Range Validator: The Range Validator control is used to check that the user enters an input between two values. User can check between numbers, dates and characters.<br> 

     <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="Text_DOB" Display="Dynamic" ErrorMessage="Age must be between 18 and 45" ForeColor="Red"               Set FocusOnError="True" Type="Date">Age not in range</asp:RangeValidator> 
     
- Compare Validator: The Compare Validator is used to compare the values of one input control to the another input control or to a fixed value. If the input control value is empty then no validation occurs.<br>
 
    <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="Text_pwd" ControlToValidate="Text_conform" Display="Dynamic" ErrorMessage="Password and conform      password must be same" ForeColor="Red" SetFocusOnError="True">Password Mismatched</asp:CompareValidator>
   
- Regular Expression: The Regular Expression validator control is used to ensure that an input value matches a specifies pattern. It is useful for checking email address, phone numbers, zip codes, etc. The validation will not fail is the input control is empty.<br>

    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="Text_email" Display="Dynamic" ErrorMessage="Email id is incorrect"         ForeColor="Red" SetFocusOnError="True" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">Invalid Email id</asp:RegularExpressionValidator>
        <br>
- Custom Validator: The custom validator allows the user to write a method to handle the validation of the value entered. It is used to compare the users input to a value in the database or the arithmetic validations for the controls.

  <asp:CustomValidator ID="CustomValidator1" runat="server" ControlToValidate="Text_pwd" Display="Dynamic" ErrorMessage="Password must contain" ForeColor="Red"   OnServerValidate="CustomValidator1_ServerValidate" SetFocusOnError="True" ValidateEmptyText="True">Invalid Password</asp:CustomValidator>
 
- Validation Summary: The Validation Summary control is used to display the summary of all validation errors in a web page. 


## User-Controls in ASP.NET

- Behaves like miniature ASP.NET pages or web forms, which could be used by many other pages.
- Have an .ascx extension
- Does not have standard html tags.
- They have control directive instead of page directive.
