$(document).ready(function(){
    $('.main-slider').owlCarousel({
        loop:true,
        margin: 0,
        nav: false,
        items: 1,
        autoplay: true,
        autoplayTimeout: 3000
    })
    $('.news-slider').owlCarousel({
        loop:true,
        margin:10,
        nav:false,
        items: 3,
        autoplay: true,
        autoplayTimeout: 3000
    })
});
