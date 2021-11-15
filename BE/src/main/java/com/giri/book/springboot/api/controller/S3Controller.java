package com.giri.book.springboot.api.controller;

import com.giri.book.springboot.api.service.DownloadS3;
import lombok.RequiredArgsConstructor;
import org.springframework.http.ResponseEntity;
import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.GetMapping;

import java.io.IOException;

@Controller
@RequiredArgsConstructor
public class S3Controller {

    private final DownloadS3 downloadS3;

    @GetMapping("/apk_download")
    public ResponseEntity<byte[]> download() throws IOException {
        return downloadS3.getObject("iz.apk");
    }
}