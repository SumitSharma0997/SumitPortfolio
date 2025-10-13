
$(document).ready(function() {
    
    $('a[href^="#"]').on('click', function(event) {
        var target = $(this.getAttribute('href'));
        if (target.length) {
            event.preventDefault();
            $('html, body').stop().animate({
                scrollTop: target.offset().top - 70
            }, 1000);
        }
    });

    $(window).scroll(function() {
        if ($(this).scrollTop() > 50) {
            $('.navbar').addClass('navbar-scrolled');
        } else {
            $('.navbar').removeClass('navbar-scrolled');
        }
    });

    function animateSkillBars() {
        $('.skill-progress').each(function() {
            var skillLevel = $(this).data('skill-level');
            $(this).animate({
                width: skillLevel + '%'
            }, 1500);
        });
    }

    $(window).scroll(function() {
        var skillsSection = $('#skills');
        if (skillsSection.length) {
            var skillsTop = skillsSection.offset().top;
            var skillsBottom = skillsTop + skillsSection.outerHeight();
            var viewportTop = $(window).scrollTop();
            var viewportBottom = viewportTop + $(window).height();

            if (skillsBottom > viewportTop && skillsTop < viewportBottom) {
                if (!skillsSection.hasClass('animated')) {
                    skillsSection.addClass('animated');
                    animateSkillBars();
                }
            }
        }
    });

    $('.project-card').hover(
        function() {
            $(this).find('.project-overlay').fadeIn(300);
        },
        function() {
            $(this).find('.project-overlay').fadeOut(300);
        }
    );

    $('#contactForm').on('submit', function(e) {
        e.preventDefault();
        
        var name = $('#name').val().trim();
        var email = $('#email').val().trim();
        var message = $('#message').val().trim();
        
        if (name === '' || email === '' || message === '') {
            showAlert('Please fill in all fields.', 'danger');
            return;
        }
        
        if (!isValidEmail(email)) {
            showAlert('Please enter a valid email address.', 'danger');
            return;
        }
        
        showAlert('Thank you for your message! I will get back to you soon.', 'success');
        this.reset();
    });

    function isValidEmail(email) {
        var emailRegex = /^[^\s@]+@[^\s@]+\.[^\s@]+$/;
        return emailRegex.test(email);
    }

    function showAlert(message, type) {
        var alertHtml = '<div class="alert alert-' + type + ' alert-dismissible fade show" role="alert">' +
                       message +
                       '<button type="button" class="btn-close" data-bs-dismiss="alert"></button>' +
                       '</div>';
        
        $('#alertContainer').html(alertHtml);
        
        // Auto-hide success alerts after 5 seconds
        if (type === 'success') {
            setTimeout(function() {
                $('.alert').alert('close');
            }, 5000);
        }
    }

    function typeWriter(element, text, speed = 100) {
        let i = 0;
        element.innerHTML = '';
        
        function type() {
            if (i < text.length) {
                element.innerHTML += text.charAt(i);
                i++;
                setTimeout(type, speed);
            }
        }
        type();
    }

    const heroTitle = document.querySelector('.hero-title');
    if (heroTitle) {
        setTimeout(function() {
            typeWriter(heroTitle, 'Software Developer', 150);
        }, 1000);
    }

    // Initialize tooltips
    var tooltipTriggerList = [].slice.call(document.querySelectorAll('[data-bs-toggle="tooltip"]'));
    var tooltipList = tooltipTriggerList.map(function (tooltipTriggerEl) {
        return new bootstrap.Tooltip(tooltipTriggerEl);
    });

    // Back to top button
    $(window).scroll(function() {
        if ($(this).scrollTop() > 300) {
            $('#backToTop').fadeIn();
        } else {
            $('#backToTop').fadeOut();
        }
    });

    $('#backToTop').click(function() {
        $('html, body').animate({scrollTop: 0}, 800);
        return false;
    });

    // Mobile menu toggle
    $('.navbar-toggler').click(function() {
        $(this).toggleClass('active');
    });

    // Close mobile menu when clicking on a link
    $('.navbar-nav .nav-link').click(function() {
        $('.navbar-collapse').collapse('hide');
        $('.navbar-toggler').removeClass('active');
    });

    // Parallax effect for hero section
    $(window).scroll(function() {
        var scrolled = $(this).scrollTop();
        var parallax = $('.hero-section');
        var speed = scrolled * 0.5;
        
        if (parallax.length) {
            parallax.css('transform', 'translateY(' + speed + 'px)');
        }
    });

    // Counter animation
    function animateCounters() {
        $('.counter').each(function() {
            var $this = $(this);
            var countTo = $this.attr('data-count');
            
            $({ countNum: $this.text() }).animate({
                countNum: countTo
            }, {
                duration: 2000,
                easing: 'linear',
                step: function() {
                    $this.text(Math.floor(this.countNum));
                },
                complete: function() {
                    $this.text(this.countNum);
                }
            });
        });
    }

    // Trigger counter animation when in view
    $(window).scroll(function() {
        var countersSection = $('.counters-section');
        if (countersSection.length && !countersSection.hasClass('animated')) {
            var sectionTop = countersSection.offset().top;
            var sectionBottom = sectionTop + countersSection.outerHeight();
            var viewportTop = $(window).scrollTop();
            var viewportBottom = viewportTop + $(window).height();

            if (sectionBottom > viewportTop && sectionTop < viewportBottom) {
                countersSection.addClass('animated');
                animateCounters();
            }
        }
    });
});
