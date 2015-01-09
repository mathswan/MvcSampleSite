@Code
    Layout = "~/Views/Shared/_Layout.vbhtml"
    Page.Title = "Section 2"
End Code

<h1>@Page.Title</h1>

@ViewData("SectionDetails")

<p><img src="/Content/Images/wood.jpg" alt="Woodland Image"></p>
