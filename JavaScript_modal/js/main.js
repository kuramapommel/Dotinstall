const initModal = (openButtonId, closeButtonId, modalId, mask) => {
  'use strict';

  const openButton = document.getElementById(openButtonId);
  const closeButton = document.getElementById(closeButtonId);
  const modal = document.getElementById(modalId);

  const open = () => {
    modal.className = 'visible';
    mask.className = 'visible';
  };

  const close = () => {
    modal.className = 'hidden';
    mask.className = 'hidden';
  };

  openButton.addEventListener('click', open);
  closeButton.addEventListener('click', close);
  mask.addEventListener('click', close);
};