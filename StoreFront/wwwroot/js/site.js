// Write your JavaScript code.
$(() => {
  $(".shop-image-preview").click(function(){
    $(".shop-image-large.active, .shop-image-preview.active").removeClass("active");
    $(this).addClass("active");
    $('.shop-image-large[data-id="'+$(this).attr("data-id")+'"]').addClass("active");
  });
  $(".filter-category").click(function(){
    $(".filter-category.active").removeClass("active");
    $(this).addClass("active");
    if($(this).attr("data-id") == 0){
        $(".product-show").addClass("show");
    }else{
        $(".product-show").removeClass("show");
        $('.product-show[data-category="'+$(this).attr("data-id")+'"]').addClass("show");
    }
  });
});

