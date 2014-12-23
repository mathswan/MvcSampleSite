@Code
    Layout = "~/Views/Shared/_Layout.vbhtml"
    Page.Title = "Home"
End Code

<h1>@Page.Title</h1>

<body>
    @ViewData("Information")

    @Code 
        Html.BeginForm("About", "About", method:=FormMethod.Post)
    End Code

    <p><input type="submit" value="Next"></p>


</body>
