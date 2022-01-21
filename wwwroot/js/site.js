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
    disableOnInteraction: false,
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

var swiper = new Swiper(".swiper-img", {
  loop: true,
  autoplay: {
    delay: 4500,
    disableOnInteraction: false,
  },
  centeredSlides: true,
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

const realFileBtn2 = document.getElementById("real-file2");
const customBtn2 = document.getElementById("custom-button2");
const customTxt2 = document.getElementById("custom-text2");

customBtn2.addEventListener("click", function () {
  realFileBtn2.click();
});

realFileBtn2.addEventListener("change", function () {
  if (realFileBtn2.value) {
    customTxt2.innerHTML = realFileBtn2.value.match(
      /[\/\\]([\w\d\s\.\-\(\)]+)$/
    )[1];
  } else {
    customTxt2.innerHTML = "No file chosen, yet.";
  }
});

const realFileBtn3 = document.getElementById("real-file3");
const customBtn3 = document.getElementById("custom-button3");
const customTxt3 = document.getElementById("custom-text3");

customBtn3.addEventListener("click", function () {
  realFileBtn3.click();
});

realFileBtn3.addEventListener("change", function () {
  if (realFileBtn3.value) {
    customTxt3.innerHTML = realFileBtn3.value.match(
      /[\/\\]([\w\d\s\.\-\(\)]+)$/
    )[1];
  } else {
    customTxt3.innerHTML = "No file chosen, yet.";
  }
});
