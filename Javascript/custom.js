function getSmallestPositiveInteger() {
    const _input = $('#txtNumbers').val();
    const arrayNumber = _input.split(',').map(Number);
    const objFindNumber = arrayNumber.reduce((a, b) => {
        if (b < 0) return a;
        a[b] = b;
        return a
    }, []);

    let i = 1;
    const sortedValue = new Set(objFindNumber);
    while (sortedValue.has(i)) {
        i++;
    }
    $('#lblSmallestNumber').text("Smallest Positive Integer is : " + i);
}