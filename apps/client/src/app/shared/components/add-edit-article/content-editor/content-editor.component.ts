import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { ContentChange } from 'ngx-quill';

@Component({
    selector: 'content-editor',
    templateUrl: 'content-editor.component.html',
    styleUrls: ["content-editor.component.scss"]
})

export class ContentEditorComponent implements OnInit {
    @Input() content?: string;
    @Output() onContentChanged = new EventEmitter<string>();

    quillConfig = {
        toolbar: [
          ["bold", "italic", "underline", "strike"],
          ["blockquote", "code-block"],
    
          [{ header: 1 }, { header: 2 }],
          [{ list: "ordered" }, { list: "bullet" }],
          [{ indent: "-1" }, { indent: "+1" }],
    
          [{ size: ["small", false, "large", "huge"] }],
          [{ header: [1, 2, 3, 4, 5, 6, false] }],
    
          // [{ color: [] }, { background: [] }],
          // [{ font: [] }],
          // [{ align: [] }],
    
          ["link", "image", "video"]
        ],
        syntax: true,
      };

    constructor() { }

    ngOnInit() { }

    onChangeContent($event: ContentChange) {
      this.onContentChanged.emit($event.html);
    }
}