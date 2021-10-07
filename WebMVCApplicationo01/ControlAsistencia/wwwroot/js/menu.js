$(document).ready(function() {

    $('.nav-item dropdown a:has(i)').click(function(e){
   e.preventDefault();
   if ($(this).hasClass('activado')) {
       $(this).removeClass('activado');
       $(this).children('i').slideUp();
   }else{
       $('.nav-item dropdown a i').slideUp();
       $('.nav-item dropdown a i').removeClass('activado');
       $(this).addClass('activado');
       $(this).children('i').slideDown();
   
   }
    });  
    $('.btn-menu').click(function(){
   $('.contenedor-menu.menu').slideToggle();
    });
    $(window).resize(function(){
   if( $(document).width()>450){
       $('.contenedor-menu .menu').css({'display':'block'});
       $('menu li ul a').slideUp();
       $('.menu li').removeClass('activado');
   }
    });

    $('.menu li ul li a').click(function() {
        window.localtion.href=$(this).attr('href');
  
    }); 
}); 