﻿window.addEventListener('load', () => {
    new DataTable('.data-table', {
        pagingType: 'simple_numbers',
        responsive: true,

        initComplete: function () {
            const $searchLabel = document.querySelector('.dt-search label'),
                $searchInput = document.getElementById('dt-search-0'),
                $searchIcon = document.createElement('i'),
                $parentNode = $searchInput.parentNode;

            $searchIcon.className = 'bi bi-search position-absolute end-0 top-0 z-3 me-2 mt-2';
            $searchInput.className += ' py-2 border-black ms-0'
            $parentNode.className += ' position-relative'

            $searchLabel.remove();
            $searchInput.setAttribute('placeholder', 'Search');
            $parentNode.appendChild($searchIcon);
        }
    });
}); 