<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <title>@Page.Title</title>
    <link rel="stylesheet" type="text/css" href="~/Content/Site.css">
</head>
<body>
    <ul id="menu">
        <li>@Html.ActionLink("Home", "Index", "Home")</li>
        <li>@Html.ActionLink("About", "About", "About")</li>
    </ul>
    <section id="main">
        @RenderBody()
        <p>DSD 2014. All Rights Reserved.</p>
    </section>
</body>
</html>