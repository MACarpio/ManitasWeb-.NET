let addbtn = document.querySelector(".add-categ");
let navbar = document.querySelector(".navbar");

document.querySelector("#add-btn").onclick = () => {
  addbtn.classList.toggle("active");
  navbar.classList.remove("active");
};

document.querySelector("#menu-btn").onclick = () => {
  navbar.classList.toggle("active");
  addbtn.classList.remove("active");
};

window.onscroll = () => {
  navbar.classList.remove("active");
  addbtn.classList.remove("active");
};

var swiper = new Swiper(".product-slider", {
  loop: true,
  spaceBetween: 20,
  autoplay: {
    delay: 6000,
    disableOnInteraction: true,
  },
  centeredSlides: true,
  breakpoints: {
    0: {
      slidesPerView: 1,
    },
    768: {
      slidesPerView: 2,
    },
    1020: {
      slidesPerView: 3,
    },
  },
});

var swiper = new Swiper(".review-slider", {
  loop: false,
  spaceBetween: 20,
  centeredSlides: false,
  breakpoints: {
    0: {
      slidesPerView: 1,
    },
    768: {
      slidesPerView: 2,
    },
  },
});
const realFileBtn = document.getElementById("real-file");
const customBtn = document.getElementById("custom-button");
const customTxt = document.getElementById("custom-text");

customBtn.addEventListener("click", function () {
  realFileBtn.click();
});

realFileBtn.addEventListener("change", function () {
  if (realFileBtn.value) {
    customTxt.innerHTML = realFileBtn.value.match(
      /[\/\\]([\w\d\s\.\-\(\)]+)$/
    )[1];
  } else {
    customTxt.innerHTML = "No file chosen, yet.";
  }
});
function confirmardel() {
  txt = "si";
  if (confirm("Estas Seguro que deseas eliminar ?")) {
    txt = "si";
  } else {
    txt = "no";
  }
  document.getElementById("delete").value = txt;
}
