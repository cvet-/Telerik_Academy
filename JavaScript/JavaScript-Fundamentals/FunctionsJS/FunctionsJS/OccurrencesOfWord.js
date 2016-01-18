function countWords() {
    var temp = 'Can you can a can as a canner can can a can?';

    // the g in the regular expression says to search the whole string 
    // rather than just find the first occurrence
    var count = (temp.match(/can/g) || []).length;

    alert(count);
}