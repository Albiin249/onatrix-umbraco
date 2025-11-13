document.addEventListener('DOMContentLoaded', function () {
    const swiper = new Swiper('.serviceSwiper', {
        slidesPerView: 1.2,
        spaceBetween: 16,
        centeredSlides: true,
        centerSlidesBounds: true,
        slidesOffsetBefore: 16,
        sliderOffsetAfter: 16,

        pagination: {
            el: '.swiper-pagination',
            clickable: true,
            renderBullet: (i, className) => `<span class="${className}">${i + 1}</span>`
        },

        navigation: {
            nextEl: '.custom-next',
            prevEl: '.custom-prev'
        },

        breakpoints: {
            768: {
                slidesPerView: 2,
                grid: { rows: 2, fill: 'row' },
                slidesPerGroup: 2,
                centeredSlides: false,
                centerSlidesBounds: false,
                slidesOffsetBefore: 0,
                sliderOffsetAfter: 0,
            },

            1024: {
                slidesPerView: 3,
                grid: { rows: 2, fill: 'row' },
                slidesPerGroup: 2,
                centeredSlides: false,
                centerSlidesBounds: false,
                slidesOffsetBefore: 0,
                sliderOffsetAfter: 0,
            }
        }

    })
})