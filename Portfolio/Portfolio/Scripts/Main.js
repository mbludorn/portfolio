$(document).ready(function () {
    $('.image-next').on('click', function () {
        //get the active slide            
        var activeSlide = $('.image.active');
        //get the next slide
        var nextSlide = activeSlide.next();
        //makesure its a image slide
        if (!nextSlide.hasClass('image')) {
            nextSlide = $('.image').first();
        }

        //remove the active class add hide class to the active slide
        activeSlide.removeClass('active').addClass('hide');
        nextSlide.removeClass('hide').addClass('active');
    });
});

$(document).ready(function () {
    $('.image1-next').on('click', function () {
     
        //get the active slide            
        var activeSlide = $('.image1.active');
        //get the next slide
        var nextSlide = activeSlide.next();
        //makesure its a image slide
        if (!nextSlide.hasClass('image1')) {
            nextSlide = $('.image1').first();
        }

        //remove the active class add hide class to the active slide
        activeSlide.removeClass('active').addClass('hide');
        nextSlide.removeClass('hide').addClass('active');
    });
});

$(document).ready(function () {
    $('.image2-next').on('click', function () {
        //get the active slide            
        var activeSlide = $('.image2.active');
        //get the next slide
        var nextSlide = activeSlide.next();
        //makesure its a image slide
        if (!nextSlide.hasClass('image2')) {
            nextSlide = $('.image2').first();
        }

        //remove the active class add hide class to the active slide
        activeSlide.removeClass('active').addClass('hide');
        nextSlide.removeClass('hide').addClass('active');
    });


    $(document).ready(function () {
        $('.image-back').on('click', function () {
            //get the active slide            
            var activeSlide = $('.image.active');
            //get the next slide
            var nextSlide = activeSlide.next();
            //makesure its a image slide
            if (!nextSlide.hasClass('image')) {
                nextSlide = $('.image').last();
            }

            //remove the active class add hide class to the active slide
            activeSlide.removeClass('active').addClass('hide');
            nextSlide.removeClass('hide').addClass('active');
        });
    });

    $(document).ready(function () {
        $('.image1-back').on('click', function () {

            //get the active slide            
            var activeSlide = $('.image1.active');
            //get the next slide
            var nextSlide = activeSlide.next();
            //makesure its a image slide
            if (!nextSlide.hasClass('image1')) {
                nextSlide = $('.image1').last();
            }

            //remove the active class add hide class to the active slide
            activeSlide.removeClass('active').addClass('hide');
            nextSlide.removeClass('hide').addClass('active');
        });
    });

    $(document).ready(function () {
        $('.image2-back').on('click', function () {
            //get the active slide            
            var activeSlide = $('.image2.active');
            //get the next slide
            var nextSlide = activeSlide.next();
            //makesure its a image slide
            if (!nextSlide.hasClass('image2')) {
                nextSlide = $('.image2').last();
            }

            //remove the active class add hide class to the active slide
            activeSlide.removeClass('active').addClass('hide');
            nextSlide.removeClass('hide').addClass('active');
        });



        $('#contactajax').on('click', '.ajax-get', function () {
            //get the url from the data-url attribute
            var urlRequest = $(this).data('url');
            $.get(urlRequest, function (data) {
                $('#contentajax').html(data);
            });


        });

        //Ajax Post for contact form
        $('#contactajax').on('submit', function (event) {
            //prevents the default behavior of the form (doesn't allow it to be submitted)
            event.preventDefault();
            //see if the form is valid

            if ($(this).valid()) {
                //time to do the ajax post
                //serialize converts the form fields into a string that we can pass into our $.post() function
                var urlToPostTo = $(this).attr('action');
                var dataToSend = $(this).serialize();
                $.post(urlToPostTo, dataToSend, function (data) {
                    //update the #container element with the new html returned in the "data" param
                    $('#container').html(data);
                });

            }

        });
    });

});
