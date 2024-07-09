$.validator.addMethod('filesize', function (value, element, parm) {
    return isVaild = this.optional(element) || element.files[0].size <= parm;
});