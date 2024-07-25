"use strict"

// to select the first section
let first_section = $("#main_page")
console.log("first section is: ", first_section)

// to select the first article
let first_article = $("#main_page article:first-child")
console.log("first_article: ", first_article)

// to select the second article
let second_article = $("#main_page article:nth-child(2)")
// alternative
let second_article1 = first_article.next()
console.log("Second article: ", second_article)
console.log("Alternative second article: ", second_article1)

// list all the descendants of second article
let second_desc = $(".blue_black p, .blue_black aside, .blue_black h3")
console.log("second article desc: ", second_desc)
// list all alternatives way of second article
let all_desc_alt = $(".blue_black").find("*")
console.log("All. way--", all_desc_alt)


// list all the descendants of second article has p tags
let second_p_desc = $(".blue_black p")
console.log("All p tags desc: ", second_p_desc)

// make a red color black background to the article number 2
let old_color = $(".blue_black")
old_color.addClass("new_color")
old_color.removeClass("old_color")
console.log("old: ", old_color)

// to add large font to article number 2
let article_div = $(".blue_black")
setTimeout(() => {
    article_div.toggleClass("large_font")
}, 5000)

// validate the data entered in a form
$(document).ready((0))