## Page Redirection in asp.net:

You can redirect from one page to another using 
### 1.Response.Redirect()
- For Example There are 2 web pages Webform1.aspx and Webform2.aspx, There is a Button in Webform1 when that button is clicked the user should be redirected to webform2
So in Webform1.aspx.cs <br>
protected void Button1_Click(object sender, EventArgs e)<br>{<br>
     Response.Redirect("Webform2.aspx");<br>
}

* Response.Redirect(string url) issues a 302 HTTP status code instructing the client to redirect to url. The browser will issue a new request for url and the URL will change in the address bar.

### 2. server.Transfer():
terminates execution of the current page and starts execution of a new page on the specified path i.e. internally within IIS. Therefore the URL in the browser address bar will not be changed. The page you transfer to must be an aspx page in the same web site.

 Use Response.Redirect if the URL has changed and future visits to the content should be on the new URL. Use Server.Transfer if the URL is correct and current but you need to display different content this one time - maybe you are displaying an error message or you need the user to enter their credentials to continue or there is some other reason why the content should change but the URL should not.

Either of the above can be used within the Click event handler of an ASP.NET Button control in your code-behind:

- protected void Button1_Click(object sender, EventArgs e)<br>
 {<br>
    Response.Redirect("Webform2.aspx");<br>
      // OR<br>
    Server.Transfer("Webform2.aspx");<br>
 }

Both Response.Redirect and Server.Transfer methods are used to transfer a user from one web page to another web page. Both methods are used for the same purpose but still there are some differences as follows.

The Response.Redirect method redirects a request to a new URL and specifies the new URL while the Server.Transfer method for the current request, terminates execution of the current page and starts execution of a new page using the specified URL path of the page.

### 3.Server.Execute():<br>
Server.Execute allows only relative URL.
The code present after Server.Execute() will  be executed.
In Server.Execute source and destination pages must be present in same website .
             
 protected void Button1_Click(object sender, EventArgs e) <br>{<br>
    Server.Execute("Webform2.aspx");<br>
    Response.Write("Message");<br>
}
            
             
