<script src="~/js/site.js" asp-append-version="true"></script>

$(document).ready(function () {
    $('a[href*="#"]').on('click', function (e) {
        e.preventDefault();
        $('html, body').animate({
            scrollTop: $($(this).attr('href')).offset().top - 70
        }, 500, 'linear');
    });
});