@Code
    Layout = "~/Views/Shared/_Layout.vbhtml"
    Page.Title = "Home"
End Code

<h1>@Page.Title</h1>

<body>
    @ViewData("Information")

    @Code 
        Html.BeginForm("About", "Home", method:=FormMethod.Post)
    End Code

    <p>@ViewData("NameLabel")</p>

    <p><input type="text" id="NameTextbox" /></p>

    <p><input type="submit" id="Next" value="Next"></p>

</body>
