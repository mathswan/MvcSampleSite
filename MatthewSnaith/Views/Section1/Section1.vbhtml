@Code
    Layout = "~/Views/Shared/_Layout.vbhtml"
    Page.Title = "Section 1"
End Code

<h1>@Page.Title</h1>

@ViewData("SectionDetails")

<p><img src="http://nees.oregonstate.edu/killer_wave/wave.jpg" alt="Wave Image"></p>