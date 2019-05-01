var blazorVirtualScrolling = {
    init: function(ref, cmp) {

        ref.addEventListener("scroll",
            (e) => {
//                console.log(e);
                cmp.invokeMethodAsync("VirtualScrollingSetView", blazorVirtualScrolling.getScrollView(ref))
                    .then(_ => {
//                        console.log(_);
                    });

            });

        window.addEventListener("resize",
            (e) => {
//                console.log(e);


                cmp.invokeMethodAsync("VirtualScrollingSetView", blazorVirtualScrolling.getScrollView(ref))
                    .then(_ => {
//                        console.log(_);
                    });

            });
        return blazorVirtualScrolling.getScrollView(ref);


    },

    getScrollView(ref) {
        return { scrollTop: ref.scrollTop, clientHeight: ref.clientHeight };

    }

};